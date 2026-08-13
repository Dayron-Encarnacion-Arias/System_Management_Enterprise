using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Data;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmRoles : Form
    {
        private ConexionBD db = new ConexionBD();
        private int idSeleccionado = 0;
        private bool modoEdicion = false;

        public FrmRoles()
        {
            InitializeComponent();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarCampos();

            txtBuscar.Text = "Buscar...";
            txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            txtBuscar.GotFocus += (s, ev) =>
            {
                if (txtBuscar.Text == "Buscar...")
                { txtBuscar.Text = ""; txtBuscar.ForeColor = System.Drawing.Color.White; }
            };
            txtBuscar.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                { txtBuscar.Text = "Buscar..."; txtBuscar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100); }
            };
        }

        // ── CARGA DE DATOS ────────────────────────────────────────────────────
        private void CargarDatos(string busqueda = "")
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@Busqueda", busqueda == "Buscar..." ? "" : busqueda)
                };
                DataTable dt = db.EjecutarProcedimiento("sp_BuscarRoles", p);
                dgvRoles.DataSource = dt;
                FormatearGrid();
                lblTotal.Text = $"Total: {dt.Rows.Count} registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (dgvRoles.Columns.Count == 0) return;
            if (dgvRoles.Columns.Contains("IdRol"))
            { dgvRoles.Columns["IdRol"].HeaderText = "ID"; dgvRoles.Columns["IdRol"].Width = 50; }
            if (dgvRoles.Columns.Contains("NombreRol"))
            { dgvRoles.Columns["NombreRol"].HeaderText = "Nombre del Rol"; }
            if (dgvRoles.Columns.Contains("Descripcion"))
            { dgvRoles.Columns["Descripcion"].HeaderText = "Descripción"; }
            if (dgvRoles.Columns.Contains("FechaCreacion"))
            { dgvRoles.Columns["FechaCreacion"].HeaderText = "Fecha Creación"; dgvRoles.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy"; }
        }

        // ── GUARDAR (Insertar / Actualizar) ───────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {
                if (modoEdicion)
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@IdRol",      idSeleccionado),
                        new SqlParameter("@NombreRol",  txtNombreRol.Text.Trim()),
                        new SqlParameter("@Descripcion", txtDescripcion.Text.Trim())
                    };
                    DataTable res = db.EjecutarProcedimiento("sp_ActualizarRol", p);
                    int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;

                    if (resultado == -1)
                    { MessageBox.Show("Ya existe un rol con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    MessageBox.Show("✅ Rol actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlParameter[] p =
                    {
                        new SqlParameter("@NombreRol",  txtNombreRol.Text.Trim()),
                        new SqlParameter("@Descripcion", txtDescripcion.Text.Trim())
                    };
                    DataTable res = db.EjecutarProcedimiento("sp_InsertarRol", p);
                    int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;

                    if (resultado == -1)
                    { MessageBox.Show("Ya existe un rol con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    MessageBox.Show("✅ Rol registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── ELIMINAR ──────────────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            { MessageBox.Show("Seleccione un rol de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("¿Está seguro que desea eliminar este rol?\n\nNota: No se puede eliminar si tiene usuarios asignados.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlParameter[] p = { new SqlParameter("@IdRol", idSeleccionado) };
                    DataTable res = db.EjecutarProcedimiento("sp_EliminarRol", p);
                    int resultado = res.Rows.Count > 0 ? Convert.ToInt32(res.Rows[0][0]) : 0;

                    if (resultado == -2)
                    { MessageBox.Show("No se puede eliminar: el rol tiene usuarios asignados.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    MessageBox.Show("✅ Rol eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDatos();
                }
                catch (Exception ex)
                { MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        // ── SELECCIÓN EN GRID ─────────────────────────────────────────────────
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvRoles.Rows[e.RowIndex];
            idSeleccionado       = Convert.ToInt32(fila.Cells["IdRol"].Value);
            txtNombreRol.Text    = fila.Cells["NombreRol"].Value?.ToString() ?? "";
            txtDescripcion.Text  = fila.Cells["Descripcion"].Value?.ToString() ?? "";
            modoEdicion          = true;
            btnGuardar.Text      = "✏️  Actualizar";
        }

        // ── FILTRAR ───────────────────────────────────────────────────────────
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text == "Buscar..." ? "" : txtBuscar.Text.Trim();
            CargarDatos(busqueda);
        }

        // ── VALIDACIÓN ────────────────────────────────────────────────────────
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            { MessageBox.Show("El nombre del rol es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtNombreRol.Focus(); return false; }
            return true;
        }

        // ── LIMPIAR ───────────────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            modoEdicion    = false;
            txtNombreRol.Clear();
            txtDescripcion.Clear();
            btnGuardar.Text = "💾  Guardar";
            txtNombreRol.Focus();
        }
    }
}
