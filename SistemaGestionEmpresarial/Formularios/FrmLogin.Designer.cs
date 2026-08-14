namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            // Fondo principal
            this.panelFondo = new System.Windows.Forms.Panel();
            // Barra de título personalizada
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleBarText = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnMaxRestore = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            // Maletines decorativos
            this.lblMal1 = new System.Windows.Forms.Label();
            this.lblMal2 = new System.Windows.Forms.Label();
            this.lblMal3 = new System.Windows.Forms.Label();
            this.lblMal4 = new System.Windows.Forms.Label();
            this.lblMal5 = new System.Windows.Forms.Label();
            this.lblMal6 = new System.Windows.Forms.Label();
            this.lblMal7 = new System.Windows.Forms.Label();
            this.lblMal8 = new System.Windows.Forms.Label();
            this.lblMal9 = new System.Windows.Forms.Label();
            // Líneas decorativas
            this.panelLineaTop = new System.Windows.Forms.Panel();
            this.panelLineaBottom = new System.Windows.Forms.Panel();
            // Card central
            this.panelCard = new System.Windows.Forms.Panel();
            this.panelCardTop = new System.Windows.Forms.Panel();
            this.lblIconoBriefcase = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.panelCardBody = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnOjo = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();

            this.panelFondo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.panelCardTop.SuspendLayout();
            this.panelCardBody.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(10, 10, 10);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);
            var CARD = System.Drawing.Color.FromArgb(28, 28, 28);
            var BARRA = System.Drawing.Color.FromArgb(15, 15, 15);

            // ══ BARRA DE TÍTULO PERSONALIZADA ════════════════════
            this.panelTitleBar.BackColor = BARRA;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Height = 34;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            this.panelTitleBar.DoubleClick += new System.EventHandler(this.panelTitleBar_DoubleClick);

            // Ícono + texto en la barra
            this.lblTitleBarText.Text = "💼  Sistema de Gestión Empresarial";
            this.lblTitleBarText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleBarText.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblTitleBarText.Location = new System.Drawing.Point(10, 0);
            this.lblTitleBarText.Size = new System.Drawing.Size(500, 34);
            this.lblTitleBarText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleBarText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.lblTitleBarText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.lblTitleBarText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            this.lblTitleBarText.DoubleClick += new System.EventHandler(this.panelTitleBar_DoubleClick);

            // Botón Cerrar (X)
            this.btnCerrarVentana.Text = "✕";
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.Width = 46;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.BackColor = BARRA;
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnCerrarVentana.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            this.btnCerrarVentana.MouseEnter += (s, e) => { this.btnCerrarVentana.BackColor = ROJO; this.btnCerrarVentana.ForeColor = System.Drawing.Color.White; };
            this.btnCerrarVentana.MouseLeave += (s, e) => { this.btnCerrarVentana.BackColor = BARRA; this.btnCerrarVentana.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180); };

            // Botón Maximizar/Restaurar
            this.btnMaxRestore.Text = "🗗";
            this.btnMaxRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxRestore.Width = 46;
            this.btnMaxRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxRestore.FlatAppearance.BorderSize = 0;
            this.btnMaxRestore.BackColor = BARRA;
            this.btnMaxRestore.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnMaxRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaxRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxRestore.Click += new System.EventHandler(this.btnMaxRestore_Click);
            this.btnMaxRestore.MouseEnter += (s, e) => { this.btnMaxRestore.BackColor = System.Drawing.Color.FromArgb(50, 50, 50); this.btnMaxRestore.ForeColor = System.Drawing.Color.White; };
            this.btnMaxRestore.MouseLeave += (s, e) => { this.btnMaxRestore.BackColor = BARRA; this.btnMaxRestore.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180); };

            // Botón Minimizar
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Width = 46;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.BackColor = BARRA;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += (s, e) => { this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(50, 50, 50); this.btnMinimizar.ForeColor = System.Drawing.Color.White; };
            this.btnMinimizar.MouseLeave += (s, e) => { this.btnMinimizar.BackColor = BARRA; this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180); };

            this.panelTitleBar.Controls.Add(this.lblTitleBarText);
            this.panelTitleBar.Controls.Add(this.btnCerrarVentana);
            this.panelTitleBar.Controls.Add(this.btnMaxRestore);
            this.panelTitleBar.Controls.Add(this.btnMinimizar);

            // ══ FONDO NEGRO ═══════════════════════════════════════
            this.panelFondo.BackColor = NEGRO;
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;

            // Maletines decorativos
            void Maletin(System.Windows.Forms.Label l, int x, int y, int size, int alpha)
            {
                l.Text = "💼";
                l.Font = new System.Drawing.Font("Segoe UI Emoji", size);
                l.ForeColor = System.Drawing.Color.FromArgb(alpha, 180, 0, 0);
                l.BackColor = System.Drawing.Color.Transparent;
                l.Location = new System.Drawing.Point(x, y);
                l.AutoSize = true;
                this.panelFondo.Controls.Add(l);
            }

            Maletin(this.lblMal1, 30, 20, 52, 180);
            Maletin(this.lblMal2, 165, 85, 28, 90);
            Maletin(this.lblMal3, 85, 215, 36, 110);
            Maletin(this.lblMal4, 25, 420, 22, 70);
            Maletin(this.lblMal5, 55, 540, 44, 150);
            Maletin(this.lblMal6, 1400, 40, 48, 170);
            Maletin(this.lblMal7, 1550, 150, 30, 90);
            Maletin(this.lblMal8, 1455, 340, 40, 130);
            Maletin(this.lblMal9, 1380, 530, 24, 75);

            // Líneas decorativas
            this.panelLineaTop.BackColor = ROJO;
            this.panelLineaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLineaTop.Height = 3;

            this.panelLineaBottom.BackColor = ROJO;
            this.panelLineaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLineaBottom.Height = 3;

            this.panelFondo.Controls.Add(this.panelLineaTop);
            this.panelFondo.Controls.Add(this.panelLineaBottom);
            this.panelFondo.Controls.Add(this.panelCard);

            // ══ CARD CENTRAL ══════════════════════════════════════
            this.panelCard.BackColor = CARD;
            this.panelCard.Size = new System.Drawing.Size(420, 530);
            this.panelCard.Location = new System.Drawing.Point(660, 175);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // ── TOP de la Card ─────────────────────────────────
            this.panelCardTop.BackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.panelCardTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCardTop.Height = 100;

            this.lblIconoBriefcase.Text = "💼";
            this.lblIconoBriefcase.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lblIconoBriefcase.ForeColor = System.Drawing.Color.White;
            this.lblIconoBriefcase.Location = new System.Drawing.Point(165, 10);
            this.lblIconoBriefcase.AutoSize = true;

            this.lblTituloSistema.Text = "GESTIÓN EMPRESARIAL";
            this.lblTituloSistema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Size = new System.Drawing.Size(420, 24);
            this.lblTituloSistema.Location = new System.Drawing.Point(0, 62);
            this.lblTituloSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelCardTop.Controls.Add(this.lblIconoBriefcase);
            this.panelCardTop.Controls.Add(this.lblTituloSistema);

            // ── BODY de la Card ────────────────────────────────
            this.panelCardBody.BackColor = CARD;
            this.panelCardBody.Dock = System.Windows.Forms.DockStyle.Fill;

            // Título
            this.lblBienvenida.Text = "Iniciar Sesión";
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(30, 15);
            this.lblBienvenida.AutoSize = true;

            this.lblSubtitulo.Text = "Ingresa tus credenciales para continuar";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 50);
            this.lblSubtitulo.AutoSize = true;

            // Línea roja decorativa
            var panelLinea = new System.Windows.Forms.Panel();
            panelLinea.BackColor = ROJO;
            panelLinea.Location = new System.Drawing.Point(30, 72);
            panelLinea.Size = new System.Drawing.Size(55, 3);

            // Campo Usuario
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = ROJO;
            this.lblUsuario.Location = new System.Drawing.Point(30, 90);
            this.lblUsuario.AutoSize = true;

            this.txtUsuario.Location = new System.Drawing.Point(30, 108);
            this.txtUsuario.Size = new System.Drawing.Size(355, 26);
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.BackColor = INPUT;
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);

            // Campo Contraseña
            this.lblContraseña.Text = "CONTRASEÑA";
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = ROJO;
            this.lblContraseña.Location = new System.Drawing.Point(30, 155);
            this.lblContraseña.AutoSize = true;

            // Panel contraseña (sin borde del sistema para poder controlar el color total)
            this.panelPassword.Location = new System.Drawing.Point(30, 173);
            this.panelPassword.Size = new System.Drawing.Size(355, 30);
            this.panelPassword.BackColor = INPUT;
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.BackColor = INPUT;   // ← mismo color que el panel
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);

            this.btnOjo.Text = "👁";
            this.btnOjo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOjo.Width = 36;
            this.btnOjo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjo.FlatAppearance.BorderSize = 0;
            this.btnOjo.BackColor = INPUT;
            this.btnOjo.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnOjo.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);

            this.panelPassword.Controls.Add(this.txtContraseña);
            this.panelPassword.Controls.Add(this.btnOjo);

            // Intentos
            this.lblIntentos.Text = "🔒  Intentos disponibles: 3";
            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIntentos.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblIntentos.Location = new System.Drawing.Point(30, 213);
            this.lblIntentos.AutoSize = true;

            // Botón Iniciar Sesión
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.Location = new System.Drawing.Point(30, 248);
            this.btnIniciarSesion.Size = new System.Drawing.Size(355, 46);
            this.btnIniciarSesion.BackColor = ROJO;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);

            // Botón Cancelar
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.Location = new System.Drawing.Point(30, 304);
            this.btnSalir.Size = new System.Drawing.Size(355, 38);
            this.btnSalir.BackColor = CARD;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = ROJO;
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Versión
            this.lblVersion.Text = "v3.2  |  Sistema de Gestión Empresarial";
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblVersion.Location = new System.Drawing.Point(30, 356);
            this.lblVersion.AutoSize = true;

            this.panelCardBody.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBienvenida, this.lblSubtitulo, panelLinea,
                this.lblUsuario, this.txtUsuario,
                this.lblContraseña, this.panelPassword,
                this.lblIntentos, this.btnIniciarSesion, this.btnSalir, this.lblVersion });

            this.panelCard.Controls.Add(this.panelCardBody);
            this.panelCard.Controls.Add(this.panelCardTop);

            // ══ FORM ══════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = NEGRO;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelFondo.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCardTop.ResumeLayout(false);
            this.panelCardTop.PerformLayout();
            this.panelCardBody.ResumeLayout(false);
            this.panelCardBody.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelFondo, panelCard, panelCardTop, panelCardBody;
        private System.Windows.Forms.Panel panelPassword, panelLineaTop, panelLineaBottom;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleBarText;
        private System.Windows.Forms.Button btnCerrarVentana, btnMaxRestore, btnMinimizar;
        private System.Windows.Forms.Label lblMal1, lblMal2, lblMal3, lblMal4, lblMal5;
        private System.Windows.Forms.Label lblMal6, lblMal7, lblMal8, lblMal9;
        private System.Windows.Forms.Label lblIconoBriefcase, lblTituloSistema, lblSubtitulo;
        private System.Windows.Forms.Label lblBienvenida, lblUsuario, lblContraseña;
        private System.Windows.Forms.Label lblIntentos, lblVersion;
        private System.Windows.Forms.TextBox txtUsuario, txtContraseña;
        private System.Windows.Forms.Button btnOjo, btnIniciarSesion, btnSalir;
    }
}