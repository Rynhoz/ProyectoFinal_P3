using System;

public class Inventario
{
	public List<Repuesto> StockRepuestos {  get; set; }

	public Inventario()
	{
		this.StockRepuestos = new List<Repuesto>();
	}
}
