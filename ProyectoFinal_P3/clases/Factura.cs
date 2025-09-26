using System;
using System.Collections.Generic;
using ProyectoFinal_P3.clases;

public class Factura
{
    //Propiedades
	public int IdFactura { get; set; }
	public Cliente Cliente { get; set; }
	public DateTime FechaDeEmision { get; set; }
	public decimal MontoTotal { get; set; }
    private int IdNFactura = 0;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cliente"></param>
    /// <param name="fechaDeEmision"></param>
    /// <param name="montoTotal"></param>
    public Factura(Cliente cliente, DateTime fechaDeEmision, decimal montoTotal)
    {
        IdNFactura++;
        this.IdFactura = IdNFactura;
        this.Cliente = cliente;
        this.FechaDeEmision = fechaDeEmision;
        this.MontoTotal = montoTotal;
    }

}
