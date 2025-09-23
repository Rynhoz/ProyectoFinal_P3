using System;

public class Equipo
{
    public int IdEquipo { get; set; }
    public int IdCliente { get; set; }
    public string Cliente { get; set; } //Este puede ser de tipo string o tipo cliente 
    public string TipoDeEquipo { get; set; }
    public string Modelo { get; set; }
    public string NumeroDeSerie { get; set; }
    public string DescripcionDelProblema { get; set; }
    public List<string> HistorialFotografico { get; set; }

    public static int NumeroIdEquipo = 0;

    public Equipo(int idEquipo, int idCliente, string tipoDeEquipo, string modelo, string numeroDeSerie, string descripcionDelProblema)
	{
		IdEquipo = idEquipo;
        IdCliente = idCliente;
        TipoDeEquipo = tipoDeEquipo;
        Modelo = modelo;
        NumeroDeSerie = numeroDeSerie;
        DescripcionDelProblema = descripcionDelProblema;
        HistorialFotografico = new List<string>();
	}

    //Nuevo cosntructor para equipo
    //
    public Equipo(int idCliente, string tipoDeEquipo, string modelo, string numeroDeSerie, string descripcionDelProblema)
    {
        NumeroIdEquipo++;
        IdEquipo = NumeroIdEquipo;
        IdCliente = idCliente;
        TipoDeEquipo = tipoDeEquipo;
        Modelo = modelo;
        NumeroDeSerie = numeroDeSerie;
        DescripcionDelProblema = descripcionDelProblema;
        HistorialFotografico = new List<string>();
    }

    public static Equipo RegistrarEquipo(int idEquipo, int idCliente, string tipo, string modelo, string numeroSerie, string descripcion)
    {
        Equipo nuevo = new Equipo(idEquipo, idCliente, tipo, modelo, numeroSerie, descripcion);
        MessageBox.Show("Equipo registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }
}
