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

            int idRepuesto = int.Parse(txtIDRepuesto.Text);
            string nombre = txtNombreRepuesto.Text;
            string descripcion = txtDescripcion.Text;
            string familia = cboxFamilia.Text;
            int stock = int.Parse(txtStock.Text);
            decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);

            Repuesto repuestoRegistrado = Repuesto.RegistrarRepuesto(idRepuesto, nombre, descripcion, familia, stock, precioUnitario); 

            listRepuestosInfo.Items.Add("------ Repuesto registrado ------");
            listRepuestosInfo.Items.Add("Nombre: " + repuestoRegistrado.Nombre);
            listRepuestosInfo.Items.Add("Stock[: " + repuestoRegistrado.Stock);
            listRepuestosInfo.Items.Add("Descripción: " + repuestoRegistrado.Descripcion);
            listRepuestosInfo.Items.Add("Precio Unitario: " + repuestoRegistrado.PrecioUnitario);
            listRepuestosInfo.Items.Add("--------------------------------------------------");

            txtIDRepuesto.Clear();
            txtNombreRepuesto.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecioUnitario.Clear();
        }
    }
}
