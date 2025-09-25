using System;

public class Equipo
{
    // Propiedades de la clase Equipo
    public int IdEquipo { get; set; }
    //public int IdCliente { get; set; }
    public string Cliente { get; set; } //Este puede ser de tipo string o tipo cliente 
    public string TipoDeEquipo { get; set; }
    public string Modelo { get; set; }
    public string NumeroDeSerie { get; set; }
    public string DescripcionDelProblema { get; set; }
    public List<string> HistorialFotografico { get; set; }

    public static int NumeroIdEquipo = 0;
    public static List<Equipo> ListaEquipos = new List<Equipo>();

 //   public Equipo(string tipoDeEquipo, string modelo, string numeroDeSerie, string descripcionDelProblema)
	//{
 //       TipoDeEquipo = tipoDeEquipo;
 //       Modelo = modelo;
 //       NumeroDeSerie = numeroDeSerie;
 //       DescripcionDelProblema = descripcionDelProblema;
 //       HistorialFotografico = new List<string>();
	//}

    //Nuevo constructor para clase Equipo
    //
    public Equipo(string tipoDeEquipo, string modelo, string numeroDeSerie, string descripcionDelProblema)
    {
        NumeroIdEquipo++;
        IdEquipo = NumeroIdEquipo;
        TipoDeEquipo = tipoDeEquipo;
        Modelo = modelo;
        NumeroDeSerie = numeroDeSerie;
        DescripcionDelProblema = descripcionDelProblema;
        HistorialFotografico = new List<string>();
    }
    /// <summary>
    /// Método que sirve para registrar un equipo con sus respectivos datos. 
    /// </summary>
    /// <param name="tipo">Tipo de Equipo</param>
    /// <param name="modelo">Modelo del Equipo</param>
    /// <param name="numeroSerie">Numero de Serie del Equipo</param>
    /// <param name="descripcion">Descripcion del Equipo</param>
    /// <returns></returns>
    public static Equipo RegistrarEquipo(string tipo, string modelo, string numeroSerie, string descripcion)
    {
        Equipo nuevo = new Equipo(tipo, modelo, numeroSerie, descripcion);
        ListaEquipos.Add(nuevo);
        MessageBox.Show("Equipo registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }
}
