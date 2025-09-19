using System;

public class Equipo
{
    public int IdEquipo { get; set; }
    public int IdCliente { get; set; }
    public string TipoDeEquipo { get; set; }
    public string Modelo { get; set; }
    public string NumeroDeSerie { get; set; }
    public string DescripcionDelProblema { get; set; }
    public List<string> HistorialFotografico { get; set; }

    public Equipo(int idEquipo, int idCliente, string tipoDeEquipo, string modelo, string numeroDeSerie, string descripcionDelProblema)
	{
		this.IdEquipo = idEquipo;
        this.IdCliente = idCliente;
        this.TipoDeEquipo = tipoDeEquipo;
        this.Modelo = modelo;   
        this.NumeroDeSerie = numeroDeSerie;
        this.DescripcionDelProblema = descripcionDelProblema;
        this.HistorialFotografico = new List<string>();
	}
}
