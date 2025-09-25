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
            //Clientes
            dgvVerUsuarios.DataSource = Usuario.CargarUsuarios();
            listaClientes = Cliente.CargarClientes();
            dgvMostrarClientesYEquipos.DataSource = null;
            dgvMostrarClientesYEquipos.DataSource = listaClientes;
            //Repuestos
            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = Repuesto.CargarRepuestos();
            //Factura
            cboxClienteFactura.DataSource = null;
            cboxClienteFactura.DataSource = Cliente.CargarClientes();
            cboxClienteFactura.DisplayMember = "Nombre";
            cboxEquipoCliente.DataSource = null;
            cboxEquipoCliente.DataSource = Equipo.CargarEquipos();
            cboxEquipoCliente.DisplayMember = "InformacionEquipo";
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                listaClientes = Cliente.CargarClientes();

                Cliente cliente = listaClientes.FirstOrDefault(c => c.IdCliente == clienteSeleccionado.IdCliente);

                if (cliente != null)
                {
                    cliente.Nombre = txtNombreCliente.Text;
                    cliente.Direccion = txtDireccionCliente.Text;
                    cliente.Telefono = txtTelefonoCliente.Text;
                    cliente.Email = txtEmailCliente.Text;
                    cliente.Equipo = (Equipo)cboxEquipoCliente.SelectedItem;

                    Cliente.GuardarClientes(listaClientes);

                    MessageBox.Show("Cliente modificado correctamente");

                    // Refrescar DataGridView
                    dgvMostrarClientesYEquipos.DataSource = null;
                    dgvMostrarClientesYEquipos.DataSource = Cliente.CargarClientes();
                }
            }
        }

        private Cliente clienteSeleccionado;

        private void dgvMostrarClientesYEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMostrarClientesYEquipos.SelectedRows.Count > 0)
            {
                btnGuardarCambios.Enabled = true;

                // Obtener cliente seleccionado
                clienteSeleccionado = (Cliente)dgvMostrarClientesYEquipos.SelectedRows[0].DataBoundItem;

                // Rellenar campos
                txtNombreCliente.Text = clienteSeleccionado.Nombre;
                txtDireccionCliente.Text = clienteSeleccionado.Direccion;
                txtTelefonoCliente.Text = clienteSeleccionado.Telefono;
                txtEmailCliente.Text = clienteSeleccionado.Email;

                cboxEquipoCliente.SelectedItem = clienteSeleccionado.Equipo;
            }
            else
            {
                btnGuardarCambios.Enabled = false;
            }
        }

        // Funciones de Registro de Repuestos
        // -----------------------------------
        

        private void btnAgregarRepuestos_Click(object sender, EventArgs e)
        {
            // Leer los datos de los TextBox
            string nombre = txtNombreRepuesto.Text.Trim();
            string descripcion = txtDescripcionRepuesto.Text.Trim();
            string familia = cboxFamiliaRepuesto.Text;
            decimal stock = numericStock.Value;
            decimal precioUnitario = numericPrecio.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(familia))
            {
                MessageBox.Show("Complete todos los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cargar repuestos existentes
            List<Repuesto> lista = Repuesto.CargarRepuestos();

            // Crear nuevo repuesto y agregarlo a la lista
            int nuevoId = lista.Any() ? lista.Max(r => r.IdRepuesto) + 1 : 1;

            Repuesto nuevo = new Repuesto
            {
                IdRepuesto = nuevoId,
                Nombre = nombre,
                Descripcion = descripcion,
                Familia = familia,
                Stock = stock,
                PrecioUnitario = precioUnitario,
                PrecioVenta = precioUnitario * 1.2m // ejemplo de margen de venta
            };

            lista.Add(nuevo);

            // Guardar en JSON
            Repuesto.GuardarRepuestos(lista);

            // Actualizar DataGridView
            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = lista;

            // Limpiar campos
            txtNombreRepuesto.Clear();
            txtDescripcionRepuesto.Clear();
            cboxFamiliaRepuesto.Text = "";
            numericStock.Value = 0;
            numericPrecio.Value = 0;

            MessageBox.Show("Repuesto agregado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarRepuestos_Click_1(object sender, EventArgs e)
        {
            if (repuestoSeleccionado != null)
            {
                List<Repuesto> lista = Repuesto.CargarRepuestos();

                Repuesto repuesto
                    = lista.FirstOrDefault(x => x.IdRepuesto == repuestoSeleccionado.IdRepuesto);
                if (repuesto != null)
                {
                    repuesto.Nombre = txtNombreRepuesto.Text.Trim();
                    repuesto.Descripcion = txtDescripcionRepuesto.Text.Trim();
                    repuesto.Familia = cboxFamiliaRepuesto.Text;
                    repuesto.Stock = numericStock.Value;
                    repuesto.PrecioUnitario = numericPrecio.Value;
                    repuesto.PrecioVenta = numericPrecio.Value * 1.2m; // margen

                    // Guardar en JSON
                    Repuesto.GuardarRepuestos(lista);

                    // Actualizar DataGridView
                    dgvRepuestos.DataSource = null;
                    dgvRepuestos.DataSource = lista;

                    MessageBox.Show("Repuesto modificado correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtNombreRepuesto.Clear();
                    txtDescripcionRepuesto.Clear();
                    cboxFamiliaRepuesto.Text = "";
                    numericStock.Value = 0;
                    numericPrecio.Value = 0;

                    btnGuardarRepuestos.Enabled = false;
                }
            }
        }

        private Repuesto repuestoSeleccionado;
        private void dgvRepuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRepuestos.SelectedRows.Count > 0)
            {
                btnGuardarRepuestos.Enabled = true;

                repuestoSeleccionado = (Repuesto)dgvRepuestos.SelectedRows[0].DataBoundItem;

                txtNombreRepuesto.Text = repuestoSeleccionado.Nombre;
                txtDescripcionRepuesto.Text = repuestoSeleccionado.Descripcion;
                cboxFamiliaRepuesto.Text = repuestoSeleccionado.Familia;
                numericStock.Value = repuestoSeleccionado.Stock;
                numericPrecio.Value = repuestoSeleccionado.PrecioUnitario;
            }
            else
            {
                btnGuardarRepuestos.Enabled = false;
            }
        }

        // Funciones de Emisión de Facturas
        // --------------------------------
        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (cboxClienteFactura.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            // Obtenenemos cliente y equipo completos
            Cliente clienteSeleccionado = (Cliente)cboxClienteFactura.SelectedItem;

            Equipo equipo = clienteSeleccionado.Equipo;

            // Obtenemos repuesto, fecha y precio
            string repuesto = txtRepuestoFactura.Text;
            decimal cantidadRepuesto = numericCantidadFactura.Value;
            DateTime fecha = dtpFechaFactura.Value;
            decimal total = numericTotal.Value;

            try
            {
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
                                 $"Cantidad: {cantidadRepuesto.ToString()}\r\n\r\n" +
                                 $"Fecha de Factura: {fecha.ToShortDateString()}\r\n" +
                                 $"Total: {total}";
                txtFactura.Text = factura;
                btnExportarFactura.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Rellene los campos dentro del rango por favor");
            }
        }

        private void btnExportarFactura_Click(object sender, EventArgs e)
        {

        }
    }
}