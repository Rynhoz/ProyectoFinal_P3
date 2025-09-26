using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_P3.clases
{
    internal class Registro
    {
        // Propiedades.
        public int IdRegistro { get; set; }
        public Repuesto RepuestoEliminado { get; set; }
        public DateTime Fecha { get; set; }

        private int NRegistro = 0;

        public static List<Registro> ListaRegistros = new List<Registro>();

        /// <summary>
        /// Constructo de la clase 
        /// </summary>
        /// <param name="repuesto"></param>
        public Registro(Repuesto repuesto)
        {
            NRegistro++;
            IdRegistro = NRegistro;
            RepuestoEliminado = repuesto;
            Fecha = DateTime.Now;
            ListaRegistros.Add(this);
        }   
    }
}
