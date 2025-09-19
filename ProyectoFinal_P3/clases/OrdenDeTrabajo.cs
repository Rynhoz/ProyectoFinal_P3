using System;

public class OrdenDeTrabajo
{
    public int IdOrden { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Estado { get; set; }
    public decimal CostoTotal { get; set; }
    public int IdCliente { get; set; }
    public int IdEquipo { get; set; }
    public int IdTecnicoAsignado { get; set; }
    public List<Repuesto> RepuestosUtilizados { get; set; }
    public string Notas { get; set; }
    
    public OrdenDeTrabajo(int idOrden, DateTime fechaCreacion, string estado, decimal costoTotal, int idCliente, int idEquipo, int idTecnicoAsignado, string notas)
	{
        this.IdOrden = idOrden;
        this.FechaCreacion = fechaCreacion;
        this.Estado = estado;   
        this.CostoTotal = costoTotal;
        this.IdCliente = idCliente;
        this.IdEquipo = idEquipo;
        this.IdTecnicoAsignado = idTecnicoAsignado;
        this.RepuestosUtilizados = new List<Repuesto>();
        this.Notas = notas;
	}
}
