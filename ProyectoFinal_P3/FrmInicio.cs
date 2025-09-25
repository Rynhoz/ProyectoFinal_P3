using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal_P3
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();
        }

        private void equpoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipo formEquipo = new FormEquipo();
            formEquipo.Show();
        }

        private void repuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepuesto formRepuesto = new FormRepuesto();
            formRepuesto.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormCliente formCliente = new FormCliente();
            //formCliente.Show();

            FormClienteYEquipo formClienteYEquipo = new FormClienteYEquipo();
            formClienteYEquipo.Show();
        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            // Leee los datos ingresados 
            string tipo = cboxTipoDEEquipo.Text;
            string modelo = txtModeloEquipo.Text;
            string numeroSerie = txtNumeroDESerieEquipo.Text;
            string descripcion = txtDescripcionDelProblemaEquipo.Text;

            // Registrar nuevo equipo
            Equipo equipoRegistrado = Equipo.RegistrarEquipo(tipo, modelo, numeroSerie, descripcion);

            // Refrescar ComboBox con todos los equipos registrados
            cboxEquipoCliente.DataSource = null;  //  Reiniciamos
            cboxEquipoCliente.DataSource = Equipo.ListaEquipos; //  Le dicimos al ComboBox de donde tomar los items
            cboxEquipoCliente.DisplayMember = "Modelo";   // Lo que se muestra en la lista

            // Limpia los TextBox
            txtModeloEquipo.Clear();
            txtNumeroDESerieEquipo.Clear();
            txtDescripcionDelProblemaEquipo.Clear();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // Leer los datos de los TextBox
            string nombre = txtNombreCliente.Text;
            string direccion = txtDireccionCliente.Text;
            string telefono = txtTelefonoCliente.Text;
            string correo = txtEmailCliente.Text;

            // Toma el equipo completo seleccionado
            Equipo equipoSeleccionado = (Equipo)cboxEquipoCliente.SelectedItem;

            // Registrar el cliente
            Cliente clienteRegistrado = Cliente.RegistrarCliente(nombre, direccion, telefono, correo);

            // Limpiar los TextBox
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();
        }

        private void bntAnadirUsuario_Click(object sender, EventArgs e)
        {
            if (cboxRolUsuario.SelectedItem != null)
            {
                string nombre = txtNombreUsuario.Text;
                string contrasena = txtContrasenaUsuario.Text;
                string rol = cboxRolUsuario.SelectedItem.ToString();

                Usuario.AgregarUsuario(nombre, contrasena, rol);

                MessageBox.Show("Usuario añadido correctamente");

                // Opcional: refrescar el DataGridView
                dgvVerUsuarios.DataSource = null;
                dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione el rol del usuario");
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                // Cargar lista completa de usuarios
                List<Usuario> usuarios = Usuario.CargarUsuarios();

                // Buscar el usuario que se está editando
                Usuario user = usuarios.FirstOrDefault(u => u.IdUsuario == usuarioSeleccionado.IdUsuario);

                if (user != null)
                {
                    // Actualizar datos
                    user.NombreUsuario = txtNombreUsuario.Text;
                    user.Contrasena = txtContrasenaUsuario.Text;
                    user.Rol = cboxRolUsuario.SelectedItem.ToString();

                    // Guardar cambios
                    Usuario.GuardarUsuarios(usuarios);

                    MessageBox.Show("Usuario modificado correctamente");

                    // Refrescar DataGridView
                    dgvVerUsuarios.DataSource = null;
                    dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();

                    // Deshabilitar edición
                    txtNombreUsuario.Text = "";
                    txtContrasenaUsuario.Text = "";
                    cboxRolUsuario.Text = "";
                    btnGuardar.Enabled = false;
                }
            }
        }

        private Usuario usuarioSeleccionado;
        private void dgvVerUsuarios_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvVerUsuarios.SelectedRows.Count > 0)
            {
                btnModificarUsuario.Enabled = true;
                btnGuardar.Visible = true;

                // Obtener el usuario seleccionado del DataGridView
                usuarioSeleccionado = (Usuario)dgvVerUsuarios.SelectedRows[0].DataBoundItem;

                // Mostrar datos en los controles
                txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
                txtContrasenaUsuario.Text = usuarioSeleccionado.Contrasena;
                cboxRolUsuario.SelectedItem = usuarioSeleccionado.Rol;
            }
            else
            {
                btnGuardar.Visible = false;
                btnModificarUsuario.Enabled = false;
            }
        }
    }
}
