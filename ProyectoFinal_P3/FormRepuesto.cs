using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal_P3
{
    public partial class FormRepuesto : Form
    {
        public FormRepuesto()
        {
            InitializeComponent();
        }

        private void btnGuardarRepuesto_Click(object sender, EventArgs e)
        {
            //Obtener datos de los Textbox
            string nombre = txtNombreRepuesto.Text;
            string descripcion = txtDescripcion.Text;
            string familia = cboxFamilia.Text;
            int stock = int.Parse(txtStock.Text);
            decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);

            // Llamar al método de la clase
            Repuesto repuestoRegistrado = Repuesto.RegistrarRepuesto(nombre, descripcion, familia, stock, precioUnitario);

            // Actualizar ListBox
            listRepuestosInfo.Items.Add("------ Repuesto registrado ------");
            listRepuestosInfo.Items.Add("Nombre: " + repuestoRegistrado.Nombre);
            listRepuestosInfo.Items.Add("Stock: " + repuestoRegistrado.Stock);
            listRepuestosInfo.Items.Add("Descripción: " + repuestoRegistrado.Descripcion);
            listRepuestosInfo.Items.Add("Precio Unitario: " + repuestoRegistrado.PrecioUnitario);
            listRepuestosInfo.Items.Add("ID del repuesto: " + repuestoRegistrado.IdRepuesto);
            listRepuestosInfo.Items.Add("--------------------------------------------------");

            // Limpiar TextBox
            txtNombreRepuesto.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecioUnitario.Clear();
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            // Validar ID
            if (!int.TryParse(txtIDRepuesto.Text, out int idRepuesto))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eliminar de la lista estática
            bool eliminado = Repuesto.EliminarRepuesto(idRepuesto);

            if (eliminado)
            {
                int indexInicio = -1;
                int indexFin = -1;

                // Buscar dentro del ListBox dónde está el bloque
                for (int inicio = 0; inicio < listRepuestosInfo.Items.Count; inicio++)
                {
                    string itemTexto = listRepuestosInfo.Items[inicio].ToString();

                    if (itemTexto.StartsWith("------ Repuesto registrado ------"))
                    {
                        indexInicio = inicio; // inicio del bloque
                    }

                    if (itemTexto.Contains($"ID del repuesto: {idRepuesto}"))
                    {
                        // seguimos hasta encontrar el fin
                        for (int fin = inicio; fin < listRepuestosInfo.Items.Count; fin++)
                        {
                            if (listRepuestosInfo.Items[fin].ToString().StartsWith("--------------------------------------------------"))
                            {
                                indexFin = fin;
                                break;
                            }
                        }
                        break;
                    }
                }

                // Si encontró el bloque, lo borra
                if (indexInicio != -1 && indexFin != -1)
                {
                    for (int recorrido = indexFin; recorrido >= indexInicio; recorrido--)
                    {
                        listRepuestosInfo.Items.RemoveAt(recorrido);
                    }
                }
            }

            // Limpiar TextBox
            txtIDRepuesto.Clear();
        }
    }
}
