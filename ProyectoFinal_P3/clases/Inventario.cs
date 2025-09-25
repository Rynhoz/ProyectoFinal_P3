using System;

public class Inventario
{
	public static List<Repuesto> StockRepuestos {  get; set; }

	public Inventario()
	{
		StockRepuestos = new List<Repuesto>();
	}

	public Inventario(Repuesto repuesto)
	{
		StockRepuestos.Add(repuesto);
	}
}
