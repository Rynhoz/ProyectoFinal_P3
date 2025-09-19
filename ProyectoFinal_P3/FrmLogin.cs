namespace ProyectoFinal_P3
{
    public partial class FrmLogin : Form
    {
        public void AbrirVentana()
        {
            MessageBox.Show("¡Bienvenido!");
            this.Hide();
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.FormClosed += (s, args) => this.Close();
            frmInicio.Show();
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Cominiquese con Administración");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirVentana();
        }
    }
}
