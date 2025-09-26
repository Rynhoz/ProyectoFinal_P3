/// <summary>
/// 
/// </summary>
public class Administrador : Usuario
{
    public List<string> PermisosEspeciales { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Administrador()
    {
        PermisosEspeciales = new List<string>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="contrasena"></param>
    /// <param name="rol"></param>
    public Administrador(string nombre, string contrasena, string rol)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        PermisosEspeciales = new List<string>();
    }
}
