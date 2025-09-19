using System;

public class Administrador : Usuario
{
    public List<string> PermisosEspeciales { get; set; }

    public Administrador()
	{
		this.IdUsuario = 01;
		this.Rol = "Administrador";
		this.PermisosEspeciales = new List<string>();
	}
}
