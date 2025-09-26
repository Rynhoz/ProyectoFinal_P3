using System;

public class Inventario
{
	/// <summary>
	/// 
	/// </summary>
	public static List<Repuesto> StockRepuestos {  get; set; }

	/// <summary>
	/// 
	/// </summary>
	public Inventario()
	{
		StockRepuestos = new List<Repuesto>();
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="repuesto"></param>
	public Inventario(Repuesto repuesto)
	{
		StockRepuestos.Add(repuesto);
	}
}
