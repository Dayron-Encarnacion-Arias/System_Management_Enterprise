using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmBitacora : Form
    {
        private ConexionBD db = new ConexionBD();

        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Busqueda",   txtBuscar.Text.Trim() == "Buscar usuario..." ? "" : txtBuscar.Text.Trim()),
                    new SqlParameter("@Resultado",  cmbResultado.SelectedItem?.ToString() ?? "Todos"),
                    new SqlParameter("@FechaDesde", chkFiltrarFecha.Checked ? (object)dtpDesde.Value.Date : DBNull.Value),
                    new SqlParameter("@FechaHasta", chkFiltrarFecha.Checked ? (object)dtpHasta.Value.Date : DBNull.Value)
                };
                DataTable dt = db.EjecutarProcedimiento("sp_ObtenerBitacora", p);
                dgvBitacora.DataSource = dt;
                FormatearGrid();
                lblTotal.Text = $"Total: {dt.Rows.Count} registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (dgvBitacora.Columns.Count == 0) return;
            if (dgvBitacora.Columns.Contains("IdAuditoria"))
            { dgvBitacora.Columns["IdAuditoria"].HeaderText = "ID"; dgvBitacora.Columns["IdAuditoria"].Width = 50; }
            if (dgvBitacora.Columns.Contains("NombreUsuario"))
                dgvBitacora.Columns["NombreUsuario"].HeaderText = "Usuario";
            if (dgvBitacora.Columns.Contains("Resultado"))
                dgvBitacora.Columns["Resultado"].HeaderText = "Resultado";
            if (dgvBitacora.Columns.Contains("FechaIntento"))
            {
                dgvBitacora.Columns["FechaIntento"].HeaderText = "Fecha / Hora";
                dgvBitacora.Columns["FechaIntento"].DefaultCellStyle.Format = "dd/MM/yyyy  HH:mm:ss";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) => CargarBitacora();
        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarBitacora();
        private void cmbResultado_SelectedIndexChanged(object sender, EventArgs e) => CargarBitacora();
        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
            CargarBitacora();
        }
        private void dtpDesde_ValueChanged(object sender, EventArgs e) { if (chkFiltrarFecha.Checked) CargarBitacora(); }
        private void dtpHasta_ValueChanged(object sender, EventArgs e) { if (chkFiltrarFecha.Checked) CargarBitacora(); }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvBitacora.Rows.Count == 0) { MessageBox.Show("No hay datos para exportar."); return; }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = $"Bitacora_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("\"BITÁCORA DE ACCESOS\"");
                    sb.AppendLine($"\"Fecha exportación:\",\"{DateTime.Now:dd/MM/yyyy HH:mm}\"");
                    sb.AppendLine();
                    sb.AppendLine("\"ID\",\"Usuario\",\"Resultado\",\"Fecha/Hora\"");
                    DataTable dt = (DataTable)dgvBitacora.DataSource;
                    foreach (DataRow r in dt.Rows)
                        sb.AppendLine($"\"{r["IdAuditoria"]}\",\"{r["NombreUsuario"]}\",\"{r["Resultado"]}\",\"{r["FechaIntento"]}\"");
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("✅ Bitácora exportada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{sfd.FileName}\"");
                }
            }
        }
    }
}