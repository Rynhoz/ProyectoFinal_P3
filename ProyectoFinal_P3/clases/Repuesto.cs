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
    public static Repuesto RegistrarRepuesto(int idRepuesto, string nombre, string descripcion, string familia, int stock, decimal precioUnitario)
    {
        Repuesto nuevo = new Repuesto(idRepuesto, nombre, descripcion, familia, stock, precioUnitario);
        MessageBox.Show("Repuesto registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }
}
