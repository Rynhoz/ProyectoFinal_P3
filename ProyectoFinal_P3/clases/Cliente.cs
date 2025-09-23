using System;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public Equipo Equipo { get; set; }
    //Nueva propiedad para la interfaz

    private int NumeroIdCliente = 4;

    public Cliente(string nombre, string direccion, string telefono, string email)
	{
        NumeroIdCliente++;
        this.IdCliente = NumeroIdCliente;
        this.Nombre = nombre;   
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.Email = email; 
	}
}
