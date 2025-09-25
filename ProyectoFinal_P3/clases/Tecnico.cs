public class Tecnico : Usuario
{
    public string Especialidad { get; set; }

    public Tecnico() { }

    public Tecnico(string nombre, string contrasena, string rol, string especialidad)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        Especialidad = especialidad;
    }
}
