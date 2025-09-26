/// <summary>
/// Clase Cajero hija de Usuario
/// </summary>
public sealed class Cajero : Usuario
{
    public int NumeroDeCaja { get; set; }

    /// <summary>
    /// Constructor de la clase
    /// </summary>
    public Cajero() { }

    /// <summary>
    /// Constructor sobrecargado de la clase
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="contrasena"></param>
    /// <param name="rol"></param>
    /// <param name="numeroCaja"></param>
    public Cajero(string nombre, string contrasena, string rol, int numeroCaja)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        NumeroDeCaja = numeroCaja;
    }
}
