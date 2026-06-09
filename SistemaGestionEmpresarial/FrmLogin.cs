using System;
using System.Windows.Forms;
using SistemaGestionEmpresarial.Servicios;

namespace SistemaGestionEmpresarial
{
    public partial class FrmLogin : Form
    {
        private ServicioAutenticacion servicioAutenticacion;
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;

        public FrmLogin()
        {
            InitializeComponent();
            servicioAutenticacion = new ServicioAutenticacion();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Gestión Empresarial - Login";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
            
            lblIntentos.Text = $"Intentos disponibles: {MAX_INTENTOS - intentosFallidos}";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Ingrese el usuario", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese la contraseña", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            try
            {
                UsuarioAutenticado usuarioAutenticado = servicioAutenticacion.ValidarCredenciales(usuario, contraseña);

                if (usuarioAutenticado != null)
                {
                    intentosFallidos = 0;
                    
                    MessageBox.Show($"¡Bienvenido {usuarioAutenticado.Nombre}!", "Login Exitoso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SesionGlobal.UsuarioActual = usuarioAutenticado;

                    FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
                    menuPrincipal.Show();

                    this.Hide();
                }
                else
                {
                    intentosFallidos++;
                    lblIntentos.Text = $"Intentos disponibles: {MAX_INTENTOS - intentosFallidos}";

                    if (intentosFallidos >= MAX_INTENTOS)
                    {
                        MessageBox.Show("Ha agotado los intentos. La aplicación se cerrará.", 
                            "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Login Fallido", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error en Login", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                IniciarSesion();
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SesionGlobal.UsuarioActual == null)
            {
                Application.Exit();
            }
        }
    }
}