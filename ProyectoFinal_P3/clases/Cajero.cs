public class Cajero : Usuario
{
    public int NumeroDeCaja { get; set; }

    public Cajero() { }

    public Cajero(string nombre, string contrasena, string rol, int numeroCaja)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        NumeroDeCaja = numeroCaja;
    }
}
