public sealed class Tecnico : Usuario
{
    //Propiedad
    public string Especialidad { get; set; }

    /// <summary>
    /// Constructor de la clase
    /// </summary>
    public Tecnico() { }

    /// <summary>
    /// Constructor de la clase sobrecargado
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="contrasena"></param>
    /// <param name="rol"></param>
    /// <param name="especialidad"></param>
    public Tecnico(string nombre, string contrasena, string rol, string especialidad)
    {
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
        Especialidad = especialidad;
    }
}
