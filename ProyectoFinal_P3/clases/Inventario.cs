using System;

/// <summary>
/// Clase de Inventario
/// </summary>
public sealed class Inventario
{
	//Propiedad de la clase
	public static List<Repuesto> StockRepuestos {  get; set; }

	/// <summary>
	/// Constructor de la clase
	/// </summary>
	public Inventario()
	{
		StockRepuestos = new List<Repuesto>();
	}

    /// <summary>
    /// Constructor de la clase sobrecargado
    /// </summary>
    /// <param name="repuesto">Repuesto que va a ingresar al inventario</param>
    public Inventario(Repuesto repuesto)
	{
		StockRepuestos.Add(repuesto);
	}
}
