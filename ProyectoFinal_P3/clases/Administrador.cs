public class Administrador : Usuario
{
    public List<string> PermisosEspeciales { get; set; }

    public Administrador()
    {
        PermisosEspeciales = new List<string>();
    }

    public Administrador(string nombre, string contrasena, string rol)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        PermisosEspeciales = new List<string>();
    }
}
