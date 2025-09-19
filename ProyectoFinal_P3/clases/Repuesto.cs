using System;

public class Repuesto
{
    public int IdRepuesto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Familia { get; set; }
    public int Stock { get; set; }
    public decimal PrecioUnitario { get; set; }

    public Repuesto(int idRepuesto, string nombre, string descripcion, string familia, int stock, decimal precioUnitario)
	{
        this.IdRepuesto = idRepuesto;
        this.Nombre = nombre;   
        this.Descripcion = descripcion;
        this.Familia = familia;
        this.Stock = stock;
        this.PrecioUnitario = precioUnitario;
	}
}
