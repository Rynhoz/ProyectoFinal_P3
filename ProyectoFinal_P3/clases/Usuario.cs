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

    public Usuario() { }

    /// <summary>
    /// Metodo que verifica si el usuario existe y si ingreso bien sus datos para ingresar a la aplicacion
    /// </summary>
    public bool ValidarContrasena(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");
        }

        string json = File.ReadAllText(rutaArchivo);

        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

        return usuarios.Exists(u =>
            u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
            u.Contrasena == contrasena
        );
    }

    /// <summary>
    /// Metodo que Obtiene el rol del usuario para verfificar que permisos tiene en la aplicacion
    /// </summary>
    public string ObtenerRolUsuario(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");
        }

        string json = File.ReadAllText(rutaArchivo);

        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

        Usuario user = usuarios.Find(u => u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) && u.Contrasena == contrasena);

        if (user == null)
        {
            return "Usuario o contraseña incorrectos";
        }

        return (user.Rol == "Administrador" || user.Rol == "Cajero" || user.Rol == "Técnico") ? user.Rol : "Rol no válido";
    }

    /// <summary>
    /// Metodo que carga todos los usuarios desde el archivo JSON
    /// </summary>
    public static List<Usuario> CargarUsuarios()
    {
        string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");

        if (!File.Exists(rutaArchivo))
        {
            return new List<Usuario>();
        }

        string json = File.ReadAllText(rutaArchivo);

        return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
    }

    /// <summary>
    /// Metodo que guarda la lista de usuarios en el archivo JSON
    /// </summary>
    public static void GuardarUsuarios(List<Usuario> usuarios)
    {
        string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");
        string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }

    /// <summary>
    /// Metodo que añade un nuevo usuario al archivo JSON
    /// </summary>
    public static void AgregarUsuario(string nombre, string contrasena, string rol)
    {
        List<Usuario> usuarios = CargarUsuarios();

        Usuario nuevo = new Usuario
        {
            IdUsuario = usuarios.Count > 0 ? usuarios.Max(u => u.IdUsuario) + 1 : 1,
            NombreUsuario = nombre,
            Contrasena = contrasena,
            Rol = rol
        };

        usuarios.Add(nuevo);

        GuardarUsuarios(usuarios);
    }

    public static void AgregarUsuario(string nombre, string contrasena, string rol, int numeroCaja)
    {
        List<Usuario> usuarios = CargarUsuarios();

        Cajero nuevo = new Cajero(nombre, contrasena, rol, numeroCaja);

        usuarios.Add(nuevo);

        GuardarUsuarios(usuarios);
    }
}
