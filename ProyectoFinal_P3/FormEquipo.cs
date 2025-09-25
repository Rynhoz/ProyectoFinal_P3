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
    public partial class FormEquipo : Form
    {
        public FormEquipo()
        {
            InitializeComponent();
        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            int idEquipo = int.Parse(txtIDEquipo.Text);
            int idCliente = int.Parse(txtIDCliente.Text);
            string tipo = cboxTipoEquipo.Text;
            string modelo = txtModeloEquipo.Text;
            string numeroSerie = txtNumeroDESerie.Text;
            string descripcion = txtDescripcionProblema.Text;

            Equipo equipoRegistrado = Equipo.RegistrarEquipo(tipo, modelo, numeroSerie, descripcion);

            listRegistroEquipos.Items.Add("------ Equipo registrado ------");
            //listRegistroEquipos.Items.Add("Cliente: " + equipoRegistrado.IdCliente);
            listRegistroEquipos.Items.Add("Modelo: " + equipoRegistrado.Modelo);
            listRegistroEquipos.Items.Add("Descripción: " + equipoRegistrado.DescripcionDelProblema);
            listRegistroEquipos.Items.Add("--------------------------------------------------");

            txtIDEquipo.Clear();
            txtIDCliente.Clear();
            txtModeloEquipo.Clear();
            txtNumeroDESerie.Clear();
            txtDescripcionProblema.Clear();
        }
    }
}
