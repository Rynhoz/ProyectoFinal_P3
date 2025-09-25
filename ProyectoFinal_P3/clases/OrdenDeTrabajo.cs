using System;

public class OrdenDeTrabajo
{
    public int IdOrden { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Estado { get; set; }
    public decimal CostoTotal { get; set; }
    public Cliente Cliente { get; set; }
    public Equipo Equipo { get; set; }
    public Tecnico TecnicoAsignado { get; set; }
    public List<Repuesto> RepuestosUtilizados { get; set; }
    public string Notas { get; set; }

    private static int NumeroOrden = 0;

    public OrdenDeTrabajo(DateTime fechaCreacion, string estado, decimal costoTotal, Cliente cliente, Equipo equipo, Tecnico tecnicoAsignado, string notas)
	{
        NumeroOrden++;
        this.IdOrden = NumeroOrden;
        this.FechaCreacion = fechaCreacion;
        this.Estado = estado;   
        this.CostoTotal = costoTotal;
        this.Cliente = cliente;
        this.Equipo = equipo;
        this.TecnicoAsignado = tecnicoAsignado;
        this.RepuestosUtilizados = new List<Repuesto>();
        this.Notas = notas;
	}
}
