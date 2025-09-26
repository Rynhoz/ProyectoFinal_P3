/// <summary>
/// 
/// </summary>
public class Cajero : Usuario
{
    public int NumeroDeCaja { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Cajero() { }

    /// <summary>
    /// 
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
