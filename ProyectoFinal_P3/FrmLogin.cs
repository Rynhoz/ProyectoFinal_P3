using ProyectoFinal_P3.clases;

namespace ProyectoFinal_P3
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        public void AbrirVentana()
        {
            try
            {
                Usuario usuario = new Usuario();
                bool esValido = usuario.ValidarContrasena(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

                if (esValido)
                {
                    // Obtener el rol del usuario ingresado
                    string rol = usuario.ObtenerRolUsuario(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

                    MessageBox.Show($"¡Bienvenido {rol}!");

                    this.Hide();

                    Form ventana = null;

                    // Abrir ventana según el rol
                    switch (rol)
                    {
                        case "Administrador":
                            ventana = new FrmInicio(rol);
                            break;

                        case "Tecnico":
                            ventana = new FrmInicio(rol);
                            break;

                        case "Cajero":
                            ventana = new FrmInicio(rol);
                            break;

                        default:
                            MessageBox.Show("Rol no reconocido, contacte con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                            return;
                    }

                    // Manejo de cierre
                    if (ventana != null)
                    {
                        ventana.FormClosed += (s, args) => this.Close();
                        ventana.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Archivo de usuarios no encontrado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Comuniquese con Administración");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContrasena.Text != "")
            {
                AbrirVentana();
            }
            else
            {
                MessageBox.Show("Rellene los campos de texto para ingresar");
            }

        }
    }
}
