using System;

public class Tecnico : Usuario
{
	public string Especialidad { get; set; }
    public List<OrdenDeTrabajo> OrdenesAsignadas { get; set; }

    public Tecnico(string nombre, string contrasena, string rol, string especialidad)
	{
        NumeroIdUsuario++;
        IdUsuario = NumeroIdUsuario;
        NombreUsuario = nombre;
        Contrasena = contrasena;
        Rol = rol;
		Especialidad = especialidad;
        OrdenesAsignadas = new List<OrdenDeTrabajo>();
    }
}
