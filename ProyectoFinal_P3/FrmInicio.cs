using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal_P3
{
    public partial class FrmInicio : Form
    {
        private Usuario usuarioSeleccionado;
        private List<Cliente> listaClientes;

        // Constructores y Carga del Formulario
        // ------------------------------------
        public FrmInicio(string RolUsuario)
        {
            InitializeComponent();
            if (RolUsuario == "Administrador")
            {
                // Administrador ve todas, no quitamos nada
            }
            else if (RolUsuario == "Tecnico")
            {
                // Técnico oculta 1 pestaña (ejemplo tabPage4)
                tabInicio.TabPages.Remove(tpAdministrador);
            }
            else if (RolUsuario == "Cajero")
            {
                // Cajero oculta 2 pestañas (ejemplo tabPage3 y tabPage4)
                tabInicio.TabPages.Remove(tpAdministrador);
                tabInicio.TabPages.Remove(tpClienteYEquipo);
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();
            listaClientes = Cliente.CargarClientes();
            dgvMostrarClientesYEquipos.DataSource = null;
            dgvMostrarClientesYEquipos.DataSource = listaClientes;
        }

        // Funciones de Registro, Modificación y Visualización de Usuarios
        // ----------------------------------------------------------------
        private void bntAnadirUsuario_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasenaUsuario.Text.Trim();
            string rol = cboxRolUsuario.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Complete todos los campos antes de añadir un usuario");
                return;
            }

            Usuario nuevo;

            if (rol == "Administrador")
            {
                nuevo = new Administrador(nombre, contrasena, rol);
            }
            else if (rol == "Técnico")
            {
                nuevo = new Tecnico(nombre, contrasena, rol, txtEspecialidad.Text.Trim());
            }
            else if (rol == "Cajero")
            {
                int numeroCaja = int.TryParse(txtEspecialidad.Text, out int result) ? result : 0;
                nuevo = new Cajero(nombre, contrasena, rol, numeroCaja);
            }
            else
            {
                nuevo = new Usuario { NombreUsuario = nombre, Contrasena = contrasena, Rol = rol };
            }

            Usuario.AgregarUsuario(nuevo);

            MessageBox.Show("Usuario añadido correctamente");

            // Refrescar tabla
            dgvVerUsuarios.DataSource = null;
            dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();

            txtNombreUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
            cboxRolUsuario.Text = "";
        }

        private void cboxRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxRolUsuario.SelectedIndex == 1)
            {
                lblEspecialidad.Enabled = true;
                txtEspecialidad.Enabled = true;
                lblEspecialidad.Text = "ESPECIALIDAD";
            }
            else if (cboxRolUsuario.SelectedIndex == 2)
            {
                lblEspecialidad.Enabled = true;
                txtEspecialidad.Enabled = true;
                lblEspecialidad.Text = "NÚMERO DE CAJA";
            }
            else
            {
                lblEspecialidad.Enabled = false;
                txtEspecialidad.Enabled = false;
            }
        }

        private void dgvVerUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVerUsuarios.SelectedRows.Count > 0)
            {
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
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
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
                    txtEspecialidad.Text = "";
                    btnGuardar.Enabled = false;
                }
            }
        }

        // Funciones de Registro de Clientes y Equipos
        // --------------------------------------------
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text.Trim();
            string direccion = txtDireccionCliente.Text.Trim();
            string telefono = txtTelefonoCliente.Text.Trim();
            string correo = txtEmailCliente.Text.Trim();

            Equipo equipoSeleccionado = (Equipo)cboxEquipoCliente.SelectedItem;

            if (string.IsNullOrWhiteSpace(nombre) || equipoSeleccionado == null)
            {
                MessageBox.Show("Debe ingresar el nombre y seleccionar un equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente clienteRegistrado = Cliente.RegistrarCliente(nombre, direccion, telefono, correo, equipoSeleccionado);

            // Refrescar DataGridView
            dgvMostrarClientesYEquipos.DataSource = null;
            dgvMostrarClientesYEquipos.DataSource = Cliente.CargarClientes();

            // Limpiar campos
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();

            // Refrescar ComboBox de clientes en Facturas
            cboxClienteFactura.DataSource = null;
            cboxClienteFactura.DataSource = Cliente.CargarClientes();
            cboxClienteFactura.DisplayMember = "Nombre";
        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            string tipo = cboxTipoDEEquipo.Text.Trim();
            string modelo = txtModeloEquipo.Text.Trim();
            string numeroSerie = txtNumeroDESerieEquipo.Text.Trim();
            string descripcion = txtDescripcionDelProblemaEquipo.Text.Trim();

            if (string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Debe ingresar al menos el tipo de equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipo equipoRegistrado = Equipo.RegistrarEquipo(tipo, modelo, numeroSerie, descripcion);

            // Refrescar ComboBox
            cboxEquipoCliente.DataSource = null;
            cboxEquipoCliente.DataSource = Equipo.CargarEquipos();
            cboxEquipoCliente.DisplayMember = "InformacionEquipo";

            // Autoseleccionar el recién agregado
            cboxEquipoCliente.SelectedItem = equipoRegistrado;

            // Limpiar campos
            txtModeloEquipo.Clear();
            txtNumeroDESerieEquipo.Clear();
            txtDescripcionDelProblemaEquipo.Clear();

            btnRegistrarCliente.Enabled = true;

        }

        private void dgvMostrarClientesYEquipos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cliente.GuardarClientes(listaClientes);
        }

        // Funciones de Registro de Repuestos
        // -----------------------------------
        private void btnGuardarRepuestos_Click(object sender, EventArgs e)
        {
            // Leer los datos de los TextBox
            string nombre = txtNombreRepuesto.Text;
            string descripcion = txtDescripcionRepuesto.Text;
            string familia = cboxFamiliaRepuesto.Text;
            decimal stock = numericStock.Value;
            decimal precioUnitario = numericPrecio.Value;

            Repuesto repuestoRegistrado = Repuesto.RegistrarRepuesto(nombre, descripcion, familia, stock, precioUnitario);
        }

        // Funciones de Emisión de Facturas
        // --------------------------------
        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            // Obtenenemos cliente y equipo completos
            Cliente clienteSeleccionado = (Cliente)cboxClienteFactura.SelectedItem;

            Equipo equipo = clienteSeleccionado.Equipo;

            // Obtenemos repuesto, fecha y precio
            string repuesto = txtRepuestoFactura.Text;
            DateTime fecha = dtpFechaFactura.Value;
            decimal total = numericTotal.Value;

            // Hacemos la estructura de la factura
            string factura = $"--- FACTURA ---\r\n\r\n" +
                             $"Cliente: {clienteSeleccionado.Nombre} {clienteSeleccionado.Direccion}\r\n" +
                             $"Dirección: {clienteSeleccionado.Direccion}\r\n" +
                             $"Teléfono: {clienteSeleccionado.Telefono}\r\n" +
                             $"Correo: {clienteSeleccionado.Email}\r\n\r\n" +
                             $"Equipo asignado:\r\n" +
                             $"Tipo: {equipo.TipoDeEquipo}\r\n" +
                             $"Modelo: {equipo.Modelo}\r\n" +
                             $"Número de Serie: {equipo.NumeroDeSerie}\r\n" +
                             $"Descripción: {equipo.DescripcionDelProblema}\r\n\r\n" +
                             $"Repuestos:\r\n" +
                             $"Nombre: {repuesto}\r\n" +
                             $"Cantidad: {repuesto}\r\n\r\n" +
                             $"Fecha de Factura: {fecha.ToShortDateString()}\r\n" +
                             $"Total: {total}";
            txtFactura.Text = factura;
            btnExportarFactura.Enabled = true;
        }

        private void btnExportarFactura_Click(object sender, EventArgs e)
        {

        }
    }
}