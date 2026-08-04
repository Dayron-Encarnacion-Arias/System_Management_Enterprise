using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Modelos;
using SistemaGestionEmpresarial.Servicios;

namespace SistemaGestionEmpresarial.Formularios
{
    public partial class FrmLogin : Form
    {
        private ServicioAutenticacion servicioAutenticacion;
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;
        private bool mostrandoPassword = false;
        private bool estaMaximizado = true;
        private Size tamañoNormal = new Size(1366, 768);
        private Point posicionNormal = new Point(100, 100);

        private readonly Color ROJO_PRINCIPAL = Color.FromArgb(211, 47, 47);
        private readonly Color ROJO_HOVER = Color.FromArgb(244, 67, 54);
        private readonly Color ROJO_INPUT = Color.FromArgb(60, 10, 10);
        private readonly Color INPUT_NORMAL = Color.FromArgb(40, 40, 40);

        public FrmLogin()
        {
            InitializeComponent();
            servicioAutenticacion = new ServicioAutenticacion();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Gestión Empresarial";
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            estaMaximizado = true;

            ActualizarIntentos();
            ConfigurarHoverEffects();
            ConfigurarPlaceholders();
            CentrarCard();
        }

        private void CentrarCard()
        {
            panelCard.Location = new Point(
                (this.ClientSize.Width - panelCard.Width) / 2,
                (this.ClientSize.Height - panelCard.Height) / 2);
        }

        // ── CONTROLES DE VENTANA PERSONALIZADOS ───────────────
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxRestore_Click(object sender, EventArgs e)
        {
            if (estaMaximizado)
            {
                // Pasar a ventana normal
                posicionNormal = new Point(200, 100);
                tamañoNormal = new Size(1100, 700);
                this.WindowState = FormWindowState.Normal;
                this.Size = tamañoNormal;
                this.Location = posicionNormal;
                btnMaxRestore.Text = "🗖";
                estaMaximizado = false;
            }
            else
            {
                // Volver a pantalla completa
                this.WindowState = FormWindowState.Maximized;
                btnMaxRestore.Text = "🗗";
                estaMaximizado = true;
            }
            CentrarCard();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        // Arrastrar la ventana desde el título
        private bool dragging = false;
        private Point dragStart;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { dragging = true; dragStart = e.Location; }
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;
            if (estaMaximizado)
            {
                // Salir de maximizado al arrastrar
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1100, 700);
                this.Location = new Point(Cursor.Position.X - 550, Cursor.Position.Y - 15);
                btnMaxRestore.Text = "🗖";
                estaMaximizado = false;
                dragStart = new Point(550, 15);
                CentrarCard();
                return;
            }
            Point diff = Point.Subtract(Cursor.Position, new Size(dragStart));
            this.Location = new Point(
                this.Location.X + e.Location.X - dragStart.X,
                this.Location.Y + e.Location.Y - dragStart.Y);
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e) => dragging = false;

        private void panelTitleBar_DoubleClick(object sender, EventArgs e)
            => btnMaxRestore_Click(sender, e);

        // ── HOVER EFFECTS ─────────────────────────────────────
        private void ConfigurarHoverEffects()
        {
            // Botón Iniciar — glow rojo
            btnIniciarSesion.MouseEnter += (s, e) => {
                btnIniciarSesion.BackColor = ROJO_HOVER;
                btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 100, 100);
                btnIniciarSesion.FlatAppearance.BorderSize = 2;
            };
            btnIniciarSesion.MouseLeave += (s, e) => {
                btnIniciarSesion.BackColor = ROJO_PRINCIPAL;
                btnIniciarSesion.FlatAppearance.BorderSize = 0;
            };

            // Botón Cancelar — borde rojo hover
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.FlatAppearance.BorderColor = ROJO_HOVER;
                btnSalir.ForeColor = ROJO_HOVER;
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.FlatAppearance.BorderColor = ROJO_PRINCIPAL;
                btnSalir.ForeColor = Color.FromArgb(180, 180, 180);
            };

            // Campo usuario — fondo rojo oscuro al enfocar
            txtUsuario.GotFocus += (s, e) => txtUsuario.BackColor = ROJO_INPUT;
            txtUsuario.LostFocus += (s, e) => txtUsuario.BackColor = INPUT_NORMAL;

            // Campo contraseña — AMBOS el panel Y el textbox cambian de color
            txtContraseña.GotFocus += (s, e) => {
                panelPassword.BackColor = ROJO_INPUT;
                txtContraseña.BackColor = ROJO_INPUT;  // ← FIX: también el textbox
                btnOjo.BackColor = ROJO_INPUT;
            };
            txtContraseña.LostFocus += (s, e) => {
                panelPassword.BackColor = INPUT_NORMAL;
                txtContraseña.BackColor = INPUT_NORMAL; // ← FIX: también el textbox
                btnOjo.BackColor = INPUT_NORMAL;
            };
        }

        // ── PLACEHOLDERS ──────────────────────────────────────
        private void ConfigurarPlaceholders()
        {
            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.ForeColor = Color.FromArgb(100, 100, 100);
            txtUsuario.GotFocus += (s, ev) => {
                if (txtUsuario.Text == "Ingrese su usuario")
                {
                    txtUsuario.Text = "";
                    txtUsuario.ForeColor = Color.White;
                }
            };
            txtUsuario.LostFocus += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    txtUsuario.Text = "Ingrese su usuario";
                    txtUsuario.ForeColor = Color.FromArgb(100, 100, 100);
                }
            };

            txtContraseña.PasswordChar = '\0';
            txtContraseña.Text = "Ingrese su contraseña";
            txtContraseña.ForeColor = Color.FromArgb(100, 100, 100);
            txtContraseña.GotFocus += (s, ev) => {
                if (txtContraseña.Text == "Ingrese su contraseña")
                {
                    txtContraseña.Text = "";
                    txtContraseña.ForeColor = Color.White;
                    txtContraseña.PasswordChar = '*';
                }
            };
            txtContraseña.LostFocus += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    txtContraseña.Text = "Ingrese su contraseña";
                    txtContraseña.ForeColor = Color.FromArgb(100, 100, 100);
                    txtContraseña.PasswordChar = '\0';
                }
            };

            this.ActiveControl = null;
        }

        private void ActualizarIntentos()
        {
            int restantes = MAX_INTENTOS - intentosFallidos;
            lblIntentos.Text = $"🔒  Intentos disponibles: {restantes}";
            lblIntentos.ForeColor = restantes == 1
                ? Color.FromArgb(255, 80, 80)
                : Color.FromArgb(150, 150, 150);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e) => IniciarSesion();

        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario == "Ingrese su usuario" || string.IsNullOrEmpty(usuario))
            { MessageBox.Show("Ingrese su usuario.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (contraseña == "Ingrese su contraseña" || string.IsNullOrEmpty(contraseña))
            { MessageBox.Show("Ingrese su contraseña.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                btnIniciarSesion.Enabled = false;
                btnIniciarSesion.Text = "Verificando...";

                UsuarioAutenticado user = servicioAutenticacion.ValidarCredenciales(usuario, contraseña);

                if (user != null)
                {
                    SesionGlobal.UsuarioActual = user;
                    new FrmMDIPrincipal().Show();
                    this.Hide();
                }
                else
                {
                    intentosFallidos++;
                    ActualizarIntentos();
                    if (intentosFallidos >= MAX_INTENTOS)
                    {
                        MessageBox.Show("Ha agotado todos los intentos.\nLa aplicación se cerrará.",
                            "Acceso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); return;
                    }
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    this.ActiveControl = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnIniciarSesion.Enabled = true;
                btnIniciarSesion.Text = "INICIAR SESIÓN";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña") return;
            mostrandoPassword = !mostrandoPassword;
            txtContraseña.PasswordChar = mostrandoPassword ? '\0' : '*';
            btnOjo.Text = mostrandoPassword ? "🙈" : "👁";
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        { if (e.KeyChar == (char)Keys.Return) { IniciarSesion(); e.Handled = true; } }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        { if (e.KeyChar == (char)Keys.Return) { txtContraseña.Focus(); e.Handled = true; } }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        { if (SesionGlobal.UsuarioActual == null) Application.Exit(); }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                CentrarCard();
        }
    }
}