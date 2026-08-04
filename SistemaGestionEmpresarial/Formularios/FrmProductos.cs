using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmProductos : Form
    {
        private ConexionBD db = new ConexionBD();
        private int idSeleccionado = 0;
        private bool modoEdicion = false;
        private bool puedeAgregar, puedeModificar, puedeEliminar;

        private const string PLACEHOLDER = "Buscar...";

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ConfigurarPermisos();
            CargarCategorias();
            CargarDatos();
            LimpiarCampos();
            ConfigurarPlaceholder();
        }

        private void ConfigurarPlaceholder()
        {
            txtBuscar.Text = PLACEHOLDER;
            txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            txtBuscar.GotFocus += (s, ev) => {
                if (txtBuscar.Text == PLACEHOLDER) { txtBuscar.Text = ""; txtBuscar.ForeColor = System.Drawing.Color.White; }
            };
            txtBuscar.LostFocus += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = PLACEHOLDER; txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100); }
            };
        }

        private void ConfigurarPermisos()
        {
            string rol = SesionGlobal.UsuarioActual?.NombreRol ?? "";
            puedeAgregar = rol == "Administrador" || rol == "Ejecutor";
            puedeModificar = rol == "Administrador" || rol == "Supervisor";
            puedeEliminar = rol == "Administrador";
            btnGuardar.Enabled = puedeAgregar || puedeModificar;
            btnEliminar.Enabled = puedeEliminar;
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable dt = db.EjecutarProcedimiento("sp_ObtenerCategorias");

                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = dt;
                cmbCategoria.DisplayMember = "NombreCategoria";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;

                DataTable dtF = dt.Copy();
                DataRow r = dtF.NewRow();
                r["IdCategoria"] = 0; r["NombreCategoria"] = "Todas";
                dtF.Rows.InsertAt(r, 0);
                cmbFiltroCategoria.DataSource = null;
                cmbFiltroCategoria.DataSource = dtF;
                cmbFiltroCategoria.DisplayMember = "NombreCategoria";
                cmbFiltroCategoria.ValueMember = "IdCategoria";
                cmbFiltroCategoria.SelectedIndex = 0;
            }
            catch { }
        }

        private void CargarDatos(string busqueda = "", int idCategoria = 0, string estado = "Todos")
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Busqueda",    busqueda),
                    new SqlParameter("@IdCategoria", idCategoria),
                    new SqlParameter("@Estado",      estado)
                };
                DataTable dt = db.EjecutarProcedimiento("sp_BuscarProductos", p);
                dgvProductos.DataSource = dt;
                FormatearGrid();
                lblTotal.Text = $"Total: {dt.Rows.Count} registros";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void FormatearGrid()
        {
            if (dgvProductos.Columns.Count == 0) return;
            if (dgvProductos.Columns.Contains("IdProducto")) { dgvProductos.Columns["IdProducto"].HeaderText = "ID"; dgvProductos.Columns["IdProducto"].Width = 45; }
            if (dgvProductos.Columns.Contains("Codigo")) dgvProductos.Columns["Codigo"].HeaderText = "Código";
            if (dgvProductos.Columns.Contains("Nombre")) dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvProductos.Columns.Contains("Precio")) { dgvProductos.Columns["Precio"].HeaderText = "Precio"; dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2"; }
            if (dgvProductos.Columns.Contains("Stock")) dgvProductos.Columns["Stock"].HeaderText = "Stock";
            if (dgvProductos.Columns.Contains("IdCategoria")) dgvProductos.Columns["IdCategoria"].Visible = false;
            if (dgvProductos.Columns.Contains("NombreCategoria")) dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
            if (dgvProductos.Columns.Contains("Estado")) dgvProductos.Columns["Estado"].HeaderText = "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                SqlParameter[] p;
                if (modoEdicion)
                    p = new SqlParameter[] {
                        new SqlParameter("@IdProducto",  idSeleccionado),
                        new SqlParameter("@Codigo",      txtCodigo.Text.Trim()),
                        new SqlParameter("@Nombre",      txtNombre.Text.Trim()),
                        new SqlParameter("@Precio",      decimal.Parse(txtPrecio.Text)),
                        new SqlParameter("@Stock",       int.Parse(txtStock.Text)),
                        new SqlParameter("@IdCategoria", cmbCategoria.SelectedValue),
                        new SqlParameter("@Estado",      cmbEstado.SelectedItem.ToString())
                    };
                else
                    p = new SqlParameter[] {
                        new SqlParameter("@Codigo",      txtCodigo.Text.Trim()),
                        new SqlParameter("@Nombre",      txtNombre.Text.Trim()),
                        new SqlParameter("@Precio",      decimal.Parse(txtPrecio.Text)),
                        new SqlParameter("@Stock",       int.Parse(txtStock.Text)),
                        new SqlParameter("@IdCategoria", cmbCategoria.SelectedValue),
                        new SqlParameter("@Estado",      cmbEstado.SelectedItem.ToString())
                    };

                string sp = modoEdicion ? "sp_ActualizarProducto" : "sp_InsertarProducto";
                DataTable res = db.EjecutarProcedimiento(sp, p);
                int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;

                if (resultado == -1)
                { MessageBox.Show("El código ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                MessageBox.Show(modoEdicion ? "✅ Producto actualizado." : "✅ Producto registrado.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Seleccione un producto."); return; }

            if (MessageBox.Show("¿Eliminar el producto seleccionado?\n(Se marcará como Inactivo)",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // DELETE directo — más confiable
                    using (SqlConnection conn = new SqlConnection(
                        "Server=.;Database=GestionEmpresarial;Integrated Security=true;"))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(
                            "UPDATE Productos SET Estado = 'Inactivo' WHERE IdProducto = @Id", conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                            int filas = cmd.ExecuteNonQuery();
                            if (filas > 0)
                            {
                                MessageBox.Show("✅ Producto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                CargarDatos();
                            }
                            else MessageBox.Show("No se encontró el producto.", "Aviso");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message); }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvProductos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
            txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
            txtStock.Text = fila.Cells["Stock"].Value.ToString();
            if (fila.Cells["IdCategoria"].Value != null)
                cmbCategoria.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
            cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
            modoEdicion = true;
            btnGuardar.Text = "✏️  Actualizar";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();

        private void Filtrar()
        {
            try
            {
                int catId = 0;
                if (cmbFiltroCategoria.SelectedItem is DataRowView drv)
                    catId = Convert.ToInt32(drv["IdCategoria"]);
                string b = txtBuscar.Text == PLACEHOLDER ? "" : txtBuscar.Text.Trim();
                CargarDatos(b, catId, cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos");
            }
            catch { CargarDatos(); }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            { MessageBox.Show("El código es obligatorio."); return false; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("El nombre es obligatorio."); return false; }
            if (!decimal.TryParse(txtPrecio.Text, out _))
            { MessageBox.Show("El precio debe ser un número válido."); return false; }
            if (!int.TryParse(txtStock.Text, out _))
            { MessageBox.Show("El stock debe ser un número entero."); return false; }
            if (cmbCategoria.SelectedIndex < 0)
            { MessageBox.Show("Seleccione una categoría."); return false; }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idSeleccionado = 0; modoEdicion = false;
            txtCodigo.Clear(); txtNombre.Clear();
            txtPrecio.Text = "0"; txtStock.Text = "0";
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Text = "💾  Guardar";
            txtCodigo.Focus();
        }
    }
}