using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_P3.clases;

namespace ProyectoFinal_P3.clases
{
    public class ItemFactura //clase innecesaria
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; }

        public ItemFactura(string nombre, int cantidad, decimal precioUnitario)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
            this.Subtotal = cantidad * precioUnitario;
        }
    }
}
