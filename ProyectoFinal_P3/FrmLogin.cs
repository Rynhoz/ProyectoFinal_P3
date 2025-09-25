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
                    MessageBox.Show("¡Bienvenido!");
                    this.Hide();

                    FrmInicio frmInicio = new FrmInicio();
                    frmInicio.FormClosed += (s, args) => this.Close();
                    frmInicio.Show();
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
