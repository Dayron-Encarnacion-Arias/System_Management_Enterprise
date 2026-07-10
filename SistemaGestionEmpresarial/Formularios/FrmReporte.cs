using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    /// <summary>
    /// Formulario de reporte dinámico para Clientes o Productos.
    /// Incluye filtros, vista previa, impresión y exportación a CSV.
    /// </summary>
    public partial class FrmReporte : Form
    {
        private ConexionBD db = new ConexionBD();
        private string tipoReporte;   // "Clientes" o "Productos"
        private DataTable dtReporte;
        private PrintDocument printDoc;

        public FrmReporte(string tipo)
        {
            InitializeComponent();
            tipoReporte = tipo;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            lblTituloReporte.Text = $"📊 Reporte de {tipoReporte}";
            this.Text = $"Reporte de {tipoReporte}";
            ConfigurarFiltrosPorTipo();
            GenerarReporte();
        }

        private void ConfigurarFiltrosPorTipo()
        {
            if (tipoReporte == "Clientes")
            {
                lblFiltro.Text = "Filtrar por Estado:";
                cmbFiltro.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
                cmbFiltro.SelectedIndex = 0;
                lblFiltro2.Visible = false;
                cmbFiltro2.Visible = false;
            }
            else // Productos
            {
                lblFiltro.Text = "Filtrar por Categoría:";
                DataTable cats = db.EjecutarProcedimiento("sp_ObtenerCategorias");
                DataRow r = cats.NewRow(); r["IdCategoria"] = 0; r["NombreCategoria"] = "Todas";
                cats.Rows.InsertAt(r, 0);
                cmbFiltro.DataSource = cats;
                cmbFiltro.DisplayMember = "NombreCategoria";
                cmbFiltro.ValueMember = "IdCategoria";
                cmbFiltro.SelectedIndex = 0;

                lblFiltro2.Visible = true;
                cmbFiltro2.Visible = true;
                lblFiltro2.Text = "Estado:";
                cmbFiltro2.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
                cmbFiltro2.SelectedIndex = 0;
            }
        }

        private void GenerarReporte()
        {
            try
            {
                SqlParameter[] p;
                string sp;

                if (tipoReporte == "Clientes")
                {
                    sp = "sp_ReporteClientes";
                    string estado = cmbFiltro.SelectedItem?.ToString() ?? "Todos";
                    p = new SqlParameter[] { new SqlParameter("@Estado", estado) };
                }
                else
                {
                    sp = "sp_ReporteProductos";
                    int catId = cmbFiltro.SelectedValue != null ? Convert.ToInt32(cmbFiltro.SelectedValue) : 0;
                    string estado = cmbFiltro2.SelectedItem?.ToString() ?? "Todos";
                    p = new SqlParameter[] {
                        new SqlParameter("@IdCategoria", catId),
                        new SqlParameter("@Estado", estado)
                    };
                }

                DataSet ds = new DataSet();
                // Ejecutar SP que retorna 2 ResultSets
                var conn = db.ObtenerConexion();
                using (var cmd = new System.Data.SqlClient.SqlCommand(sp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(p);
                    using (var da = new System.Data.SqlClient.SqlDataAdapter(cmd))
                        da.Fill(ds);
                }
                db.Desconectar();

                dtReporte = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                int total = ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0
                    ? Convert.ToInt32(ds.Tables[1].Rows[0]["TotalRegistros"]) : dtReporte.Rows.Count;

                // Mostrar en grid
                dgvReporte.DataSource = dtReporte;
                FormatearGrid();

                // Cabecera del reporte
                lblFechaGeneracion.Text = $"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}";
                lblTotalRegistros.Text = $"Total de registros: {total}";
                lblGeneradoPor.Text = $"Generado por: {SesionGlobal.UsuarioActual?.Nombre}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (tipoReporte == "Clientes" && dgvReporte.Columns.Contains("FechaRegistro"))
                dgvReporte.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (tipoReporte == "Productos" && dgvReporte.Columns.Contains("Precio"))
                dgvReporte.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        // ── BOTONES ───────────────────────────────────────────
        private void btnGenerar_Click(object sender, EventArgs e) => GenerarReporte();

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            if (dtReporte == null || dtReporte.Rows.Count == 0)
            { MessageBox.Show("No hay datos para exportar."); return; }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = $"Reporte_{tipoReporte}_{DateTime.Now:yyyyMMdd_HHmm}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    // Encabezados
                    sb.AppendLine($"\"REPORTE DE {tipoReporte.ToUpper()}\"");
                    sb.AppendLine($"\"Fecha:\",\"{DateTime.Now:dd/MM/yyyy HH:mm}\"");
                    sb.AppendLine($"\"Total registros:\",\"{dtReporte.Rows.Count}\"");
                    sb.AppendLine();
                    // Columnas
                    for (int i = 0; i < dtReporte.Columns.Count; i++)
                    {
                        sb.Append($"\"{dtReporte.Columns[i].ColumnName}\"");
                        if (i < dtReporte.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                    // Datos
                    foreach (DataRow row in dtReporte.Rows)
                    {
                        for (int i = 0; i < dtReporte.Columns.Count; i++)
                        {
                            sb.Append($"\"{row[i]}\"");
                            if (i < dtReporte.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show($"Reporte exportado exitosamente:\n{sfd.FileName}",
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir archivo
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{sfd.FileName}\"");
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtReporte == null || dtReporte.Rows.Count == 0)
            { MessageBox.Show("No hay datos para imprimir."); return; }

            printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.DocumentName = $"Reporte de {tipoReporte}";

            using (PrintPreviewDialog ppd = new PrintPreviewDialog())
            {
                ppd.Document = printDoc;
                ppd.Width = 900;
                ppd.Height = 700;
                ppd.ShowDialog();
            }
        }

        private int filaActual = 0;

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fSub = new Font("Segoe UI", 10, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 9, FontStyle.Bold);
            Font fData = new Font("Segoe UI", 8, FontStyle.Regular);

            int x = 40, y = 40;

            // Título
            g.DrawString($"REPORTE DE {tipoReporte.ToUpper()}", fTitulo, Brushes.DarkBlue, x, y); y += 30;
            g.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}   |   Total: {dtReporte.Rows.Count} registros   |   Generado por: {SesionGlobal.UsuarioActual?.Nombre}", fSub, Brushes.Gray, x, y); y += 20;
            g.DrawLine(Pens.DarkBlue, x, y, e.PageBounds.Width - 40, y); y += 10;

            // Columnas
            int[] colWidths = new int[dtReporte.Columns.Count];
            int totalW = e.PageBounds.Width - 80;
            for (int i = 0; i < dtReporte.Columns.Count; i++)
                colWidths[i] = totalW / dtReporte.Columns.Count;

            int cx = x;
            foreach (DataColumn col in dtReporte.Columns)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(41, 128, 185)), cx, y, colWidths[dtReporte.Columns.IndexOf(col)], 20);
                g.DrawString(col.ColumnName, fHeader, Brushes.White, cx + 2, y + 2);
                cx += colWidths[dtReporte.Columns.IndexOf(col)];
            }
            y += 22;

            // Filas
            bool altRow = false;
            while (filaActual < dtReporte.Rows.Count)
            {
                if (y + 18 > e.PageBounds.Height - 60) { e.HasMorePages = true; break; }
                DataRow row = dtReporte.Rows[filaActual];
                cx = x;
                if (altRow) g.FillRectangle(new SolidBrush(Color.FromArgb(235, 245, 255)), cx, y, totalW, 16);
                for (int i = 0; i < dtReporte.Columns.Count; i++)
                {
                    g.DrawString(row[i].ToString(), fData, Brushes.Black, cx + 2, y + 1);
                    cx += colWidths[i];
                }
                y += 18; filaActual++; altRow = !altRow;
            }
            if (filaActual >= dtReporte.Rows.Count) { e.HasMorePages = false; filaActual = 0; }
        }
    }
}