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

        // Permisos según rol
        private bool puedeAgregar, puedeModificar, puedeEliminar;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ConfigurarPermisos();
            CargarDatos();
            LimpiarCampos();

            txtBuscar.Text = "Buscar...";
            txtBuscar.ForeColor = System.Drawing.Color.Gray;
            txtBuscar.GotFocus += (s, ev) => { if (txtBuscar.Text == "Buscar...") { txtBuscar.Text = ""; txtBuscar.ForeColor = System.Drawing.Color.Black; } };
            txtBuscar.LostFocus += (s, ev) => { if (txtBuscar.Text == "") { txtBuscar.Text = "Buscar..."; txtBuscar.ForeColor = System.Drawing.Color.Gray; } };
        }

        // ── PERMISOS ───────────────────────────────────────────
        private void ConfigurarPermisos()
        {
            string rol = SesionGlobal.UsuarioActual?.NombreRol ?? "";
            puedeAgregar = rol == "Administrador" || rol == "Ejecutor";
            puedeModificar = rol == "Administrador" || rol == "Supervisor";
            puedeEliminar = rol == "Administrador";

            btnGuardar.Enabled = puedeAgregar || puedeModificar;
            btnEliminar.Enabled = puedeEliminar;
        }

        // ── CARGAR / BUSCAR ────────────────────────────────────
        private void CargarDatos(string busqueda = "", string estado = "Todos")
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Busqueda", busqueda),
                    new SqlParameter("@Estado", estado)
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
            dgvClientes.Columns["IdCliente"].HeaderText = "ID";
            dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["Apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
            dgvClientes.Columns["Correo"].HeaderText = "Correo";
            dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
            dgvClientes.Columns["Estado"].HeaderText = "Estado";
            dgvClientes.Columns["FechaRegistro"].HeaderText = "Fecha";
            dgvClientes.Columns["IdCliente"].Width = 50;
            dgvClientes.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // ── GUARDAR (INSERTAR / ACTUALIZAR) ───────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                if (modoEdicion && !puedeModificar)
                { MessageBox.Show("No tiene permiso para modificar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (!modoEdicion && !puedeAgregar)
                { MessageBox.Show("No tiene permiso para agregar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                string sp = modoEdicion ? "sp_ActualizarCliente" : "sp_InsertarCliente";
                SqlParameter[] p;

                if (modoEdicion)
                {
                    p = new SqlParameter[] {
                        new SqlParameter("@IdCliente", idSeleccionado),
                        new SqlParameter("@Nombre", txtNombre.Text.Trim()),
                        new SqlParameter("@Apellido", txtApellido.Text.Trim()),
                        new SqlParameter("@Telefono", txtTelefono.Text.Trim()),
                        new SqlParameter("@Correo", txtCorreo.Text.Trim()),
                        new SqlParameter("@Direccion", txtDireccion.Text.Trim()),
                        new SqlParameter("@Estado", cmbEstado.SelectedItem.ToString())
                    };
                }
                else
                {
                    p = new SqlParameter[] {
                        new SqlParameter("@Nombre", txtNombre.Text.Trim()),
                        new SqlParameter("@Apellido", txtApellido.Text.Trim()),
                        new SqlParameter("@Telefono", txtTelefono.Text.Trim()),
                        new SqlParameter("@Correo", txtCorreo.Text.Trim()),
                        new SqlParameter("@Direccion", txtDireccion.Text.Trim()),
                        new SqlParameter("@Estado", cmbEstado.SelectedItem.ToString())
                    };
                }

                DataTable resultado = db.EjecutarProcedimiento(sp, p);
                int res = resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;

                if (res == -1)
                { MessageBox.Show("El correo ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                MessageBox.Show(modoEdicion ? "Cliente actualizado correctamente." : "Cliente registrado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── ELIMINAR ──────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Seleccione un cliente.", "Aviso"); return; }
            if (!puedeEliminar) { MessageBox.Show("No tiene permiso para eliminar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show($"¿Eliminar al cliente seleccionado?\n(Se marcará como Inactivo)",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlParameter[] p = { new SqlParameter("@IdCliente", idSeleccionado) };
                    db.EjecutarProcedimiento("sp_EliminarCliente", p);
                    MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        // ── SELECCIONAR FILA DEL GRID ─────────────────────────
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
            modoEdicion = true;
            btnGuardar.Text = "✏️ Actualizar";
        }

        // ── FILTROS DE BÚSQUEDA ───────────────────────────────
        private void txtBuscar_TextChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();
        private void Filtrar() => CargarDatos(txtBuscar.Text.Trim(), cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos");

        // ── VALIDACIONES ──────────────────────────────────────
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

        // ── LIMPIAR ───────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idSeleccionado = 0; modoEdicion = false;
            txtNombre.Clear(); txtApellido.Clear(); txtTelefono.Clear();
            txtCorreo.Clear(); txtDireccion.Clear();
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Text = "💾 Guardar";
            txtNombre.Focus();
        }

        // ── BÚSQUEDA POR ID (Enter) ───────────────────────────
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Filtrar();
        }
    }
}