using System;

public class Cajero : Usuario
{
    public int NumeroDeCaja { get; set; }

    public Cajero(string nombre, string contrasena, string rol, int numeroCaja)
	{
        NumeroIdUsuario++;
        IdUsuario = NumeroIdUsuario;
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        NumeroDeCaja = numeroCaja;
	}
}
