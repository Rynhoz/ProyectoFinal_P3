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
    public static List<Cliente> ListaClientes = new List<Cliente>();

    public Cliente(string nombre, string direccion, string telefono, string email, Equipo equipo)
	{
        NumeroIdCliente++;
        this.IdCliente = NumeroIdCliente;
        this.Nombre = nombre;   
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.Email = email; 
        this.Equipo = equipo;
	}

    public static Cliente RegistrarCliente(string nombre, string direccion, string telefono, string correo, Equipo equipo)
    {
        Cliente nuevo = new Cliente(nombre, direccion, telefono, correo, equipo);
        ListaClientes.Add(nuevo);
        MessageBox.Show("Cliente registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }
}
