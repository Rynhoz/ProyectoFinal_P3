using System;
using System.Text.Json;
using ProyectoFinal_P3.clases;

public class Usuario : IAuntenticable
{
    private string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");
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

    public bool TienePermiso(string permiso)
    {
        if (Rol == "Administrador") 
            return true;
        else
            return false;
    }

    public bool ValidarContrasena(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");
        }

        string json = File.ReadAllText(rutaArchivo);

        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

        if (usuarios == null) return false;

        foreach (var u in usuarios)
        {
            if (u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
                u.Contrasena == contrasena)
            {
                return true;
            }
        }

        return false;
    }
}
