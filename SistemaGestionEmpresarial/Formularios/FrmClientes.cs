using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmClientes : Form
    {
        private ConexionBD db = new ConexionBD();
        private int idSeleccionado = 0;
        private bool modoEdicion = false;
        private bool puedeAgregar, puedeModificar, puedeEliminar;

        private const string PLACEHOLDER = "Buscar...";

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ConfigurarPermisos();
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

        private void CargarDatos(string busqueda = "", string estado = "Todos")
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Busqueda", busqueda),
                    new SqlParameter("@Estado",   estado)
                };
                DataTable dt = db.EjecutarProcedimiento("sp_BuscarClientes", p);
                dgvClientes.DataSource = dt;
                FormatearGrid();
                lblTotal.Text = $"Total: {dt.Rows.Count} registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (dgvClientes.Columns.Count == 0) return;
            if (dgvClientes.Columns.Contains("IdCliente")) { dgvClientes.Columns["IdCliente"].HeaderText = "ID"; dgvClientes.Columns["IdCliente"].Width = 50; }
            if (dgvClientes.Columns.Contains("Nombre")) dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvClientes.Columns.Contains("Apellido")) dgvClientes.Columns["Apellido"].HeaderText = "Apellido";
            if (dgvClientes.Columns.Contains("Telefono")) dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvClientes.Columns.Contains("Correo")) dgvClientes.Columns["Correo"].HeaderText = "Correo";
            if (dgvClientes.Columns.Contains("Direccion")) dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
            if (dgvClientes.Columns.Contains("Estado")) dgvClientes.Columns["Estado"].HeaderText = "Estado";
            if (dgvClientes.Columns.Contains("FechaRegistro"))
            {
                dgvClientes.Columns["FechaRegistro"].HeaderText = "Fecha";
                dgvClientes.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                if (modoEdicion && !puedeModificar)
                { MessageBox.Show("No tiene permiso para modificar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (!modoEdicion && !puedeAgregar)
                { MessageBox.Show("No tiene permiso para agregar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                SqlParameter[] p;
                if (modoEdicion)
                    p = new SqlParameter[] {
                        new SqlParameter("@IdCliente",  idSeleccionado),
                        new SqlParameter("@Nombre",     txtNombre.Text.Trim()),
                        new SqlParameter("@Apellido",   txtApellido.Text.Trim()),
                        new SqlParameter("@Telefono",   txtTelefono.Text.Trim()),
                        new SqlParameter("@Correo",     txtCorreo.Text.Trim()),
                        new SqlParameter("@Direccion",  txtDireccion.Text.Trim()),
                        new SqlParameter("@Estado",     cmbEstado.SelectedItem.ToString())
                    };
                else
                    p = new SqlParameter[] {
                        new SqlParameter("@Nombre",     txtNombre.Text.Trim()),
                        new SqlParameter("@Apellido",   txtApellido.Text.Trim()),
                        new SqlParameter("@Telefono",   txtTelefono.Text.Trim()),
                        new SqlParameter("@Correo",     txtCorreo.Text.Trim()),
                        new SqlParameter("@Direccion",  txtDireccion.Text.Trim()),
                        new SqlParameter("@Estado",     cmbEstado.SelectedItem.ToString())
                    };

                string sp = modoEdicion ? "sp_ActualizarCliente" : "sp_InsertarCliente";
                DataTable res = db.EjecutarProcedimiento(sp, p);
                int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;

                if (resultado == -1)
                { MessageBox.Show("El correo ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                MessageBox.Show(modoEdicion ? "✅ Cliente actualizado." : "✅ Cliente registrado.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            { MessageBox.Show("Seleccione un cliente."); return; }
            if (!puedeEliminar)
            { MessageBox.Show("No tiene permiso para eliminar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("¿Eliminar el cliente seleccionado?\n(Se marcará como Inactivo)",
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
                            "UPDATE Clientes SET Estado = 'Inactivo' WHERE IdCliente = @Id", conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                            int filas = cmd.ExecuteNonQuery();
                            if (filas > 0)
                            {
                                MessageBox.Show("✅ Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                CargarDatos();
                            }
                            else MessageBox.Show("No se encontró el cliente.", "Aviso");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message); }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvClientes.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
            modoEdicion = true;
            btnGuardar.Text = "✏️  Actualizar";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) Filtrar(); }

        private void Filtrar()
        {
            string b = txtBuscar.Text == PLACEHOLDER ? "" : txtBuscar.Text.Trim();
            CargarDatos(b, cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos");
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtNombre.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            { MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtApellido.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !txtCorreo.Text.Contains("@"))
            { MessageBox.Show("El correo no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCorreo.Focus(); return false; }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idSeleccionado = 0; modoEdicion = false;
            txtNombre.Clear(); txtApellido.Clear(); txtTelefono.Clear();
            txtCorreo.Clear(); txtDireccion.Clear();
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Text = "💾  Guardar";
            txtNombre.Focus();
        }
    }
}