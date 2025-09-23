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

    public static int NumeroIdUsuario = 0;

    public Usuario(){ }

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

    public string ObtenerRolUsuario(string usuario, string contrasena)
    {
        //if (!File.Exists(rutaArchivo))
        //    throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");

        string json = File.ReadAllText(rutaArchivo);

        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

        if (usuarios == null) return "Usuario no encontrado";

        foreach (var u in usuarios)
        {
            if (u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
                u.Contrasena == contrasena)
            {
                // Verificar que el rol esté permitido
                if (u.Rol == "Administrador" || u.Rol == "Cajero" || u.Rol == "Tecnico")
                    return u.Rol;
                else
                    return "Rol no válido";
            }
        }

        return "Usuario o contraseña incorrectos";
    }

}
