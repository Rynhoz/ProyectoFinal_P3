using System;
using System.Text.Json;
using ProyectoFinal_P3.clases;

public class Usuario : IAuntenticable
{
    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string Contrasena { get; set; } 
    public string Rol { get; set; }

    public Usuario(){ }

    public Usuario(int idUsuario, string nombreUsuario, string contrasena, string rol)
	{
        this.IdUsuario = idUsuario;
        this.NombreUsuario = nombreUsuario;
        this.Contrasena = contrasena;
        this.Rol = rol;
	}

    public bool ValidarContrasena(string contrasena)
    {
        return Contrasena == contrasena;
    }

    public bool TienePermiso(string permiso)
    {
        if (Rol == "Administrador") 
            return true;
        else
            return false;
    }

    public bool ValidarContrasena(string usuario, string contrasena)
    {
        throw new NotImplementedException();
    }
}
