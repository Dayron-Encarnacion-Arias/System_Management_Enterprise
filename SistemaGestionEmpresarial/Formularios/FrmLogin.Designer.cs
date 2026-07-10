namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            // Panel fondo (pantalla completa negra con maletines)
            this.panelFondo = new System.Windows.Forms.Panel();
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelCardBody = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
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
            this.panelCard.SuspendLayout();
            this.panelCardTop.SuspendLayout();
            this.panelCardBody.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();

            // ══ FONDO NEGRO PANTALLA COMPLETA ════════════════════
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;

            // ── Maletines decorativos esparcidos ─────────────────
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

            // Posiciones: arriba-izquierda, arriba-derecha, abajo-izquierda, abajo-derecha, centro-bordes
            Maletin(this.lblMal1, 30, 30, 52, 180);   // grande arriba-izq
            Maletin(this.lblMal2, 160, 90, 28, 90);   // pequeño arriba-izq
            Maletin(this.lblMal3, 80, 220, 36, 110);   // mediano izq
            Maletin(this.lblMal4, 20, 420, 22, 70);   // pequeño izq-bajo
            Maletin(this.lblMal5, 50, 550, 44, 150);   // grande abajo-izq

            // Lado derecho (se posicionan dinámicamente en Load, aquí valores aproximados)
            Maletin(this.lblMal6, 1400, 50, 48, 170);  // grande arriba-der
            Maletin(this.lblMal7, 1550, 160, 30, 90);  // pequeño
            Maletin(this.lblMal8, 1450, 340, 40, 130);  // mediano der
            Maletin(this.lblMal9, 1380, 530, 24, 75);  // pequeño abajo-der

            // Línea roja superior decorativa
            this.panelLineaTop.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.panelLineaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLineaTop.Height = 4;

            // Línea roja inferior decorativa
            this.panelLineaBottom.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.panelLineaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLineaBottom.Height = 4;

            this.panelFondo.Controls.Add(this.panelLineaTop);
            this.panelFondo.Controls.Add(this.panelLineaBottom);
            this.panelFondo.Controls.Add(this.panelCard);

            // ══ CARD CENTRAL ══════════════════════════════════════
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.panelCard.Size = new System.Drawing.Size(420, 530);
            this.panelCard.Location = new System.Drawing.Point(660, 175);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // Drag
            this.panelCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCard_MouseDown);
            this.panelCard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCard_MouseMove);
            this.panelCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCard_MouseUp);

            // ── TOP de la Card (rojo) ─────────────────────────────
            this.panelCardTop.BackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.panelCardTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCardTop.Height = 100;

            this.lblIconoBriefcase.Text = "💼";
            this.lblIconoBriefcase.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lblIconoBriefcase.ForeColor = System.Drawing.Color.White;
            this.lblIconoBriefcase.Location = new System.Drawing.Point(170, 10);
            this.lblIconoBriefcase.AutoSize = true;

            this.lblTituloSistema.Text = "GESTIÓN EMPRESARIAL";
            this.lblTituloSistema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Size = new System.Drawing.Size(380, 24);
            this.lblTituloSistema.Location = new System.Drawing.Point(20, 62);
            this.lblTituloSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelCardTop.Controls.Add(this.lblIconoBriefcase);
            this.panelCardTop.Controls.Add(this.lblTituloSistema);

            // ── BODY de la Card ───────────────────────────────────
            this.panelCardBody.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.panelCardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardBody.Padding = new System.Windows.Forms.Padding(30, 15, 30, 20);

            // Título "Iniciar Sesión"
            this.lblBienvenida.Text = "Iniciar Sesión";
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(30, 15);
            this.lblBienvenida.AutoSize = true;

            // Subtítulo
            this.lblSubtitulo.Text = "Ingresa tus credenciales para continuar";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 50);
            this.lblSubtitulo.AutoSize = true;

            // Línea roja bajo subtítulo
            var panelLinea = new System.Windows.Forms.Panel();
            panelLinea.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            panelLinea.Location = new System.Drawing.Point(30, 72);
            panelLinea.Size = new System.Drawing.Size(55, 3);

            // Label Usuario
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblUsuario.Location = new System.Drawing.Point(30, 90);
            this.lblUsuario.AutoSize = true;

            // TextBox Usuario
            this.txtUsuario.Location = new System.Drawing.Point(30, 108);
            this.txtUsuario.Size = new System.Drawing.Size(355, 26);
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);

            // Label Contraseña
            this.lblContraseña.Text = "CONTRASEÑA";
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblContraseña.Location = new System.Drawing.Point(30, 155);
            this.lblContraseña.AutoSize = true;

            // Panel contraseña
            this.panelPassword.Location = new System.Drawing.Point(30, 173);
            this.panelPassword.Size = new System.Drawing.Size(355, 30);
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);

            this.btnOjo.Text = "👁";
            this.btnOjo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOjo.Width = 36;
            this.btnOjo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjo.FlatAppearance.BorderSize = 0;
            this.btnOjo.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnOjo.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnOjo.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);

            this.panelPassword.Controls.Add(this.txtContraseña);
            this.panelPassword.Controls.Add(this.btnOjo);

            // Label intentos
            this.lblIntentos.Text = "🔒  Intentos disponibles: 3";
            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIntentos.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblIntentos.Location = new System.Drawing.Point(30, 213);
            this.lblIntentos.AutoSize = true;

            // Botón Iniciar Sesión
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.Location = new System.Drawing.Point(30, 248);
            this.btnIniciarSesion.Size = new System.Drawing.Size(355, 46);
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
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
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Versión
            this.lblVersion.Text = "v2.0  |  Sistema de Gestión Empresarial";
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblVersion.Location = new System.Drawing.Point(30, 358);
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
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelFondo);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
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
        private System.Windows.Forms.Label lblMal1, lblMal2, lblMal3, lblMal4, lblMal5;
        private System.Windows.Forms.Label lblMal6, lblMal7, lblMal8, lblMal9;
        private System.Windows.Forms.Label lblIconoBriefcase, lblTituloSistema, lblSubtitulo;
        private System.Windows.Forms.Label lblBienvenida, lblUsuario, lblContraseña;
        private System.Windows.Forms.Label lblIntentos, lblVersion;
        private System.Windows.Forms.TextBox txtUsuario, txtContraseña;
        private System.Windows.Forms.Button btnOjo, btnIniciarSesion, btnSalir;
    }
}