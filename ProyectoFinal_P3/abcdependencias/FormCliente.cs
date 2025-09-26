using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_P3
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void cboxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // Llamamos al método que carga los usuarios desde el JSON
            List<Usuario> usuarios = Usuario.CargarUsuarios();

            // Recorremos la lista y agregamos solo los nombres de usuario
            foreach (var user in usuarios)
            {
                cboxNombreCliente.Items.Add(user.NombreUsuario);
            }
        }
    }
}
