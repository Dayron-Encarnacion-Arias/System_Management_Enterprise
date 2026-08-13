using System;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Formularios;

namespace SistemaGestionEmpresarial
{
    public partial class FrmMDIPrincipal : Form
    {
        private int offsetScroll = 0;
        private Timer timerReloj;

        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMDIPrincipal_Load(object sender, EventArgs e)
        {
            if (!SesionGlobal.HayUsuarioAutenticado()) { this.Close(); return; }

            lblUsuarioActual.Text = $"💼  {SesionGlobal.UsuarioActual.Nombre}   |   Rol: {SesionGlobal.UsuarioActual.NombreRol}";
            ConfigurarMenuPorRol();

            timerReloj = new Timer();
            timerReloj.Interval = 1000;
            timerReloj.Tick += (s, ev) =>
                lblFechaHora.Text = $"📅  {DateTime.Now:dddd, dd/MM/yyyy}   🕐  {DateTime.Now:HH:mm:ss}   ";
            timerReloj.Start();

            AbrirFormulario(new FrmDashboard());
        }

        private void ConfigurarMenuPorRol()
        {
            bool esAdmin = SesionGlobal.UsuarioActual.NombreRol == "Administrador";
            usuariosToolStripMenuItem.Visible  = esAdmin;
            rolesToolStripMenuItem.Visible     = esAdmin;
            bitacoraToolStripMenuItem.Visible  = esAdmin;
        }

        // ── INICIO ────────────────────────────────────────────────
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmDashboard());

        // ── MANTENIMIENTOS ────────────────────────────────────────
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmClientes());

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmProductos());

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmUsuarios());

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmRoles());

        // ── REPORTES ──────────────────────────────────────────────
        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmReporte("Clientes"));

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmReporte("Productos"));

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
            => AbrirFormulario(new FrmBitacora());

        // ── VENTANA ───────────────────────────────────────────────
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
            => this.LayoutMdi(MdiLayout.Cascade);

        private void mosaico_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0) return;
            offsetScroll = 0;
            OrganizarMosaico();
            this.MouseWheel -= MDI_MouseWheel;
            this.MouseWheel += MDI_MouseWheel;
        }

        private void OrganizarMosaico()
        {
            int margen = 5;
            int ancho  = this.ClientSize.Width - (margen * 2);
            int alto   = 580;
            int yPos   = margen + offsetScroll;

            foreach (Form hijo in this.MdiChildren)
            {
                hijo.WindowState = FormWindowState.Normal;
                hijo.SetBounds(margen, yPos, ancho, alto);
                yPos += alto + margen;
            }
        }

        private void MDI_MouseWheel(object sender, MouseEventArgs e)
        {
            if (this.MdiChildren.Length == 0) return;

            int velocidad    = 80;
            int maximoOffset = 5;
            int altoTotal    = this.MdiChildren.Length * (580 + 5);
            int altoVisible  = this.ClientSize.Height - menuStrip1.Height - statusStrip1.Height;
            int minimoOffset = -(altoTotal - altoVisible + 10);

            if (altoTotal <= altoVisible) { offsetScroll = 5; OrganizarMosaico(); return; }

            offsetScroll += e.Delta > 0 ? velocidad : -velocidad;
            offsetScroll  = Math.Max(minimoOffset, Math.Min(maximoOffset, offsetScroll));
            OrganizarMosaico();
        }

        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren) f.Close();
        }

        // ── SESIÓN ────────────────────────────────────────────────
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerReloj?.Stop();
                SesionGlobal.CerrarSesion();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
        }

        // ── HELPER ────────────────────────────────────────────────
        private void AbrirFormulario(Form formulario)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formulario.GetType() && f.Text == formulario.Text)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.BringToFront();
                    formulario.Dispose();
                    return;
                }
            }
            formulario.MdiParent  = this;
            formulario.Show();
            formulario.WindowState = FormWindowState.Maximized;
        }
    }
}
