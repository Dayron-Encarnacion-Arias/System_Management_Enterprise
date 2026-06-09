using System;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Servicios;

namespace SistemaGestionEmpresarial
{
    public partial class FrmMenuPrincipal : Form
    {
        private ServicioAutenticacion servicioAutenticacion;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            servicioAutenticacion = new ServicioAutenticacion();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (!SesionGlobal.HayUsuarioAutenticado())
            {
                MessageBox.Show("No hay usuario autenticado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = $"Menú Principal - {SesionGlobal.UsuarioActual.Nombre}";

            lblUsuario.Text = $"Usuario: {SesionGlobal.UsuarioActual.NombreUsuario}";
            lblRol.Text = $"Rol: {SesionGlobal.UsuarioActual.NombreRol}";
            lblHora.Text = $"Hora de acceso: {SesionGlobal.UsuarioActual.FechaLogin:dd/MM/yyyy HH:mm:ss}";

            ConfigurarOpcionesSegunRol();
        }

        private void ConfigurarOpcionesSegunRol()
        {
            btnAgregar.Enabled = servicioAutenticacion.TienePermiso(
                SesionGlobal.UsuarioActual.IdRol, "Agregar");

            btnModificar.Enabled = servicioAutenticacion.TienePermiso(
                SesionGlobal.UsuarioActual.IdRol, "Modificar");

            btnEliminar.Enabled = servicioAutenticacion.TienePermiso(
                SesionGlobal.UsuarioActual.IdRol, "Eliminar");

            btnConsultar.Enabled = servicioAutenticacion.TienePermiso(
                SesionGlobal.UsuarioActual.IdRol, "Consultar");

            btnAgregar.Text = $"Agregar {(btnAgregar.Enabled ? "✓" : "✗")}";
            btnModificar.Text = $"Modificar {(btnModificar.Enabled ? "✓" : "✗")}";
            btnEliminar.Text = $"Eliminar {(btnEliminar.Enabled ? "✓" : "✗")}";
            btnConsultar.Text = $"Consultar {(btnConsultar.Enabled ? "✓" : "✗")}";

            btnAgregar.BackColor = btnAgregar.Enabled ?
                System.Drawing.Color.FromArgb(46, 204, 113) :
                System.Drawing.Color.LightGray;

            btnModificar.BackColor = btnModificar.Enabled ?
                System.Drawing.Color.FromArgb(52, 152, 219) :
                System.Drawing.Color.LightGray;

            btnEliminar.BackColor = btnEliminar.Enabled ?
                System.Drawing.Color.FromArgb(231, 76, 60) :
                System.Drawing.Color.LightGray;

            btnConsultar.BackColor = btnConsultar.Enabled ?
                System.Drawing.Color.FromArgb(241, 196, 15) :
                System.Drawing.Color.LightGray;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!btnAgregar.Enabled)
            {
                MostrarMensajePermisoInsuficiente("agregar");
                return;
            }
            MessageBox.Show("Módulo de Agregar (En desarrollo)", "Agregar");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!btnModificar.Enabled)
            {
                MostrarMensajePermisoInsuficiente("modificar");
                return;
            }
            MessageBox.Show("Módulo de Modificar (En desarrollo)", "Modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!btnEliminar.Enabled)
            {
                MostrarMensajePermisoInsuficiente("eliminar");
                return;
            }
            MessageBox.Show("Módulo de Eliminar (En desarrollo)", "Eliminar");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!btnConsultar.Enabled)
            {
                MostrarMensajePermisoInsuficiente("consultar");
                return;
            }
            MessageBox.Show("Módulo de Consultar (En desarrollo)", "Consultar");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesionGlobal.CerrarSesion();

                FrmLogin login = new FrmLogin();
                login.Show();

                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesionGlobal.CerrarSesion();
                Application.Exit();
            }
        }

        private void MostrarMensajePermisoInsuficiente(string accion)
        {
            MessageBox.Show(
                $"No tiene permisos para {accion} registros.\n\n" +
                $"Su rol '{SesionGlobal.UsuarioActual.NombreRol}' no tiene este permiso.",
                "Acceso Denegado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}