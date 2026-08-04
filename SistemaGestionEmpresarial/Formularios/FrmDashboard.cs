using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmDashboard : Form
    {
        private ConexionBD db = new ConexionBD();

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblBienvenidaUsuario.Text =
                $"Bienvenido, {SesionGlobal.UsuarioActual?.Nombre}  —  Rol: {SesionGlobal.UsuarioActual?.NombreRol}";
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            try
            {
                DataSet ds = new DataSet();
                var conn = db.ObtenerConexion();
                using (var cmd = new System.Data.SqlClient.SqlCommand("sp_ObtenerDashboard", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var da = new System.Data.SqlClient.SqlDataAdapter(cmd))
                        da.Fill(ds);
                }
                db.Desconectar();

                if (ds.Tables.Count == 0) return;

                // Tabla 0: Totales generales
                DataRow r = ds.Tables[0].Rows[0];

                // Clientes
                lblTotalClientes.Text = r["TotalClientes"].ToString();
                lblClientesActivos.Text = r["ClientesActivos"].ToString();
                lblClientesInact.Text = r["ClientesInactivos"].ToString();

                // Productos
                lblTotalProductos.Text = r["TotalProductos"].ToString();
                lblProdActivos.Text = r["ProductosActivos"].ToString();
                lblStockTotal.Text = r["StockTotal"].ToString();
                lblValorInv.Text = $"RD$ {Convert.ToDecimal(r["ValorInventario"]):N2}";

                // Usuarios
                lblTotalUsuarios.Text = r["TotalUsuarios"].ToString();

                // Tabla 1: Productos por Categoría
                if (ds.Tables.Count > 1)
                {
                    dgvCategorias.DataSource = ds.Tables[1];
                    if (dgvCategorias.Columns.Contains("NombreCategoria"))
                        dgvCategorias.Columns["NombreCategoria"].HeaderText = "Categoría";
                    if (dgvCategorias.Columns.Contains("Cantidad"))
                        dgvCategorias.Columns["Cantidad"].HeaderText = "Productos";
                }

                // Tabla 2: Últimos accesos
                if (ds.Tables.Count > 2)
                {
                    dgvAccesos.DataSource = ds.Tables[2];
                    if (dgvAccesos.Columns.Contains("NombreUsuario"))
                        dgvAccesos.Columns["NombreUsuario"].HeaderText = "Usuario";
                    if (dgvAccesos.Columns.Contains("Exitoso"))
                        dgvAccesos.Columns["Exitoso"].HeaderText = "Resultado";
                    if (dgvAccesos.Columns.Contains("FechaIntento"))
                    {
                        dgvAccesos.Columns["FechaIntento"].HeaderText = "Fecha/Hora";
                        dgvAccesos.Columns["FechaIntento"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarEstadisticas();
            MessageBox.Show("Datos actualizados correctamente.", "Actualizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}