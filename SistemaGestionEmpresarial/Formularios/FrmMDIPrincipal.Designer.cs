namespace SistemaGestionEmpresarial
{
    partial class FrmMDIPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            // Menú Inicio
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Menú Mantenimientos
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Menú Reportes
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorReporte = new System.Windows.Forms.ToolStripSeparator();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Menú Ventana
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Menú Sesión
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // Status
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // ── MENU STRIP ───────────────────────────────────────
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.inicioToolStripMenuItem,
                this.mantenimientosToolStripMenuItem,
                this.reportesToolStripMenuItem,
                this.ventanaToolStripMenuItem,
                this.sesionToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 32);

            // Inicio
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Text = "🏠  Inicio";
            this.inicioToolStripMenuItem.DropDownItems.Add(this.dashboardToolStripMenuItem);
            this.dashboardToolStripMenuItem.Text = "📊  Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);

            // Mantenimientos
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientosToolStripMenuItem.Text = "💼  Mantenimientos";
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.clientesToolStripMenuItem,
                this.productosToolStripMenuItem,
                this.usuariosToolStripMenuItem });

            this.clientesToolStripMenuItem.Text = "👥  Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            this.productosToolStripMenuItem.Text = "📦  Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            this.usuariosToolStripMenuItem.Text = "🔐  Usuarios del Sistema";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);

            // Reportes
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Text = "📋  Reportes";
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.reporteClientesToolStripMenuItem,
                this.reporteProductosToolStripMenuItem,
                this.separadorReporte,
                this.bitacoraToolStripMenuItem });

            this.reporteClientesToolStripMenuItem.Text = "📋  Reporte de Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            this.reporteProductosToolStripMenuItem.Text = "📋  Reporte de Productos";
            this.reporteProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteProductosToolStripMenuItem_Click);
            this.bitacoraToolStripMenuItem.Text = "🔎  Bitácora de Accesos";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);

            // Ventana
            this.ventanaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventanaToolStripMenuItem.Text = "🪟  Ventana";
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cascadaToolStripMenuItem,
                this.mosaicoToolStripMenuItem,
                this.cerrarTodasToolStripMenuItem });

            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            this.mosaicoToolStripMenuItem.Text = "Mosaico  ↕";
            this.mosaicoToolStripMenuItem.Click += new System.EventHandler(this.mosaico_Click);
            this.cerrarTodasToolStripMenuItem.Text = "Cerrar Todas";
            this.cerrarTodasToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodasToolStripMenuItem_Click);

            // Sesión
            this.sesionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.sesionToolStripMenuItem.Text = "🔒  Sesión";
            this.sesionToolStripMenuItem.DropDownItems.Add(this.cerrarSesionToolStripMenuItem);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);

            // ── STATUS STRIP ──────────────────────────────────────
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblUsuarioActual, this.lblFechaHora });
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.lblUsuarioActual.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Text = "💼  Usuario:";

            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Spring = true;
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaHora.Text = "";

            // ── FORM ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(1100, 756);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "💼 Sistema de Gestión Empresarial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMDIPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separadorReporte;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActual;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
    }
}