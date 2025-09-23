using System;

public class Inventario
{
	public List<Repuesto> StockRepuestos {  get; set; }

	public Inventario()
	{
		StockRepuestos = new List<Repuesto>();
	}
}
