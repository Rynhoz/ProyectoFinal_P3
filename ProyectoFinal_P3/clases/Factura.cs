using System;
using System.Collections.Generic;
using ProyectoFinal_P3.clases;

public class Factura
{
	public int IdFactura { get; set; }
	public int IdOrden { get; set; }
	public DateTime FechaDeEmision { get; set; }
	public List<ItemFactura> Items { get; set; } //posiblemente se elimine porque no apporta en nada
	public decimal MontoTotal { get; set; }

	public Factura(int idFactura, int idOrden, DateTime fechaDeEmision, decimal montoTotal)
	{
		this.IdFactura = idFactura;
		this.IdOrden = idOrden; 
		this.FechaDeEmision = fechaDeEmision;
		this.Items = new List<ItemFactura>();
		this.MontoTotal = montoTotal;
	}
}
