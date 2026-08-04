using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmUsuarios : Form
    {
        private ConexionBD db = new ConexionBD();
        private int idSeleccionado = 0;
        private bool modoEdicion = false;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarDatos();
            LimpiarCampos();

            txtBuscar.Text = "Buscar...";
            txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            txtBuscar.GotFocus += (s, ev) => { if (txtBuscar.Text == "Buscar...") { txtBuscar.Text = ""; txtBuscar.ForeColor = System.Drawing.Color.White; } };
            txtBuscar.LostFocus += (s, ev) => { if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = "Buscar..."; txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100); } };
        }

        private void CargarRoles()
        {
            try
            {
                DataTable dt = db.EjecutarProcedimiento("sp_ObtenerRoles");

                cmbRol.DataSource = null;
                cmbRol.DataSource = dt;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";
                cmbRol.SelectedIndex = -1;

                DataTable dtFiltro = dt.Copy();
                DataRow r = dtFiltro.NewRow();
                r["IdRol"] = 0; r["NombreRol"] = "Todos";
                dtFiltro.Rows.InsertAt(r, 0);
                cmbFiltroRol.DataSource = null;
                cmbFiltroRol.DataSource = dtFiltro;
                cmbFiltroRol.DisplayMember = "NombreRol";
                cmbFiltroRol.ValueMember = "IdRol";
                cmbFiltroRol.SelectedIndex = 0;
            }
            catch { }
        }

        private void CargarDatos(string busqueda = "", int idRol = 0, string activo = "Todos")
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Busqueda", busqueda == "Buscar..." ? "" : busqueda),
                    new SqlParameter("@IdRol",    idRol),
                    new SqlParameter("@Activo",   activo)
                };
                DataTable dt = db.EjecutarProcedimiento("sp_BuscarUsuarios", p);
                dgvUsuarios.DataSource = dt;
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
            if (dgvUsuarios.Columns.Count == 0) return;
            if (dgvUsuarios.Columns.Contains("IdUsuario")) { dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID"; dgvUsuarios.Columns["IdUsuario"].Width = 45; }
            if (dgvUsuarios.Columns.Contains("NombreUsuario")) dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
            if (dgvUsuarios.Columns.Contains("Nombre")) dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre Completo";
            if (dgvUsuarios.Columns.Contains("IdRol")) dgvUsuarios.Columns["IdRol"].Visible = false;
            if (dgvUsuarios.Columns.Contains("NombreRol")) dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";
            if (dgvUsuarios.Columns.Contains("Activo")) dgvUsuarios.Columns["Activo"].HeaderText = "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                if (modoEdicion)
                {
                    // Actualizar usuario
                    SqlParameter[] p = {
                        new SqlParameter("@IdUsuario",     idSeleccionado),
                        new SqlParameter("@NombreUsuario", txtNombreUsuario.Text.Trim()),
                        new SqlParameter("@Nombre",        txtNombre.Text.Trim()),
                        new SqlParameter("@IdRol",         cmbRol.SelectedValue),
                        new SqlParameter("@Activo",        cmbActivo.SelectedIndex == 0 ? 1 : 0)
                    };
                    db.EjecutarProcedimiento("sp_ActualizarUsuario", p);

                    // Cambiar contraseña si se escribió
                    if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                        SqlParameter[] pp = {
                            new SqlParameter("@IdUsuario",  idSeleccionado),
                            new SqlParameter("@Contraseña", txtContraseña.Text.Trim())
                        };
                        db.EjecutarProcedimiento("sp_CambiarPasswordUsuario", pp);
                    }
                    MessageBox.Show("✅ Usuario actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Insertar nuevo usuario
                    SqlParameter[] p = {
                        new SqlParameter("@NombreUsuario", txtNombreUsuario.Text.Trim()),
                        new SqlParameter("@Nombre",        txtNombre.Text.Trim()),
                        new SqlParameter("@Contraseña",    txtContraseña.Text.Trim()),
                        new SqlParameter("@IdRol",         cmbRol.SelectedValue)
                    };
                    DataTable res = db.EjecutarProcedimiento("sp_InsertarUsuario", p);
                    int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;
                    if (resultado == -1)
                    { MessageBox.Show("El nombre de usuario ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    MessageBox.Show("✅ Usuario registrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) { MessageBox.Show("Seleccione un usuario."); return; }
            if (MessageBox.Show("¿Desactivar este usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Server=.;Database=GestionEmpresarial;Integrated Security=true;"))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Activo = 0 WHERE IdUsuario = @Id", conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("✅ Usuario desactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvUsuarios.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtContraseña.Text = "";
            if (fila.Cells["IdRol"].Value != null)
                cmbRol.SelectedValue = Convert.ToInt32(fila.Cells["IdRol"].Value);
            bool activo = Convert.ToBoolean(fila.Cells["Activo"].Value);
            cmbActivo.SelectedIndex = activo ? 0 : 1;
            modoEdicion = true;
            btnGuardar.Text = "✏️  Actualizar";
            lblPasswordInfo.Visible = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroRol_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();
        private void cmbFiltroActivo_SelectedIndexChanged(object sender, EventArgs e) => Filtrar();

        private void Filtrar()
        {
            try
            {
                int rolId = 0;
                if (cmbFiltroRol.SelectedItem is DataRowView drv)
                    rolId = Convert.ToInt32(drv["IdRol"]);
                string busqueda = txtBuscar.Text == "Buscar..." ? "" : txtBuscar.Text.Trim();
                CargarDatos(busqueda, rolId, cmbFiltroActivo.SelectedItem?.ToString() ?? "Todos");
            }
            catch { CargarDatos(); }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            { MessageBox.Show("El nombre de usuario es obligatorio."); return false; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("El nombre completo es obligatorio."); return false; }
            if (!modoEdicion && string.IsNullOrWhiteSpace(txtContraseña.Text))
            { MessageBox.Show("La contraseña es obligatoria para nuevos usuarios."); return false; }
            if (cmbRol.SelectedIndex < 0)
            { MessageBox.Show("Seleccione un rol."); return false; }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idSeleccionado = 0; modoEdicion = false;
            txtNombreUsuario.Clear(); txtNombre.Clear(); txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
            cmbActivo.SelectedIndex = 0;
            btnGuardar.Text = "💾  Guardar";
            lblPasswordInfo.Visible = false;
            txtNombreUsuario.Focus();
        }
    }
}