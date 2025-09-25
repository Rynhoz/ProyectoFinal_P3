using System;

public class Administrador : Usuario
{
    public List<string> PermisosEspeciales { get; set; }

	public Administrador() { }
    public Administrador(string nombre, string contrasena, string rol)
	{
		NumeroIdUsuario++;
		IdUsuario = NumeroIdUsuario;
		Rol = rol;
		this.PermisosEspeciales = new List<string>();
	}
}
