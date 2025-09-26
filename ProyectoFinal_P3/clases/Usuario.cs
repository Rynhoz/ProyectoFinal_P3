using System.Text.Json;
using ProyectoFinal_P3.clases;

public class Usuario : IAuntenticable
{
    //Propiedades
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");

    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string Contrasena { get; set; }
    public string Rol { get; set; }

    public static int NumeroIdUsuario = 0;

    /// <summary>
    /// 
    /// </summary>
    public Usuario() { }

    /// <summary>
    /// Comparaciones de usuarios
    /// </summary>
    /// <param name="u1"></param>
    /// <param name="u2"></param>
    /// <returns></returns>
    public static bool operator ==(Usuario u1, Usuario u2)
    {
        if (ReferenceEquals(u1, null) && ReferenceEquals(u2, null)) return true;
        if (ReferenceEquals(u1, null) || ReferenceEquals(u2, null)) return false;
        return u1.IdUsuario == u2.IdUsuario;
    }
    public static bool operator !=(Usuario u1, Usuario u2) => !(u1 == u2);

    public override bool Equals(object obj)
    {
        return obj is Usuario usuario && this == usuario;
    }

    public override int GetHashCode()
    {
        return IdUsuario.GetHashCode();
    }

    /// <summary>
    /// Validación de login
    /// </summary>
    /// <param name="usuario"></param>
    /// <param name="contrasena"></param>
    /// <returns></returns>
    public bool ValidarContrasena(string usuario, string contrasena)
    {
        List<Usuario> usuarios = CargarUsuarios();
        return usuarios.Exists(u =>
            u.NombreUsuario.Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) &&
            u.Contrasena == contrasena.Trim()
        );
    }

    /// <summary>
    /// Obtener Rol
    /// </summary>
    /// <param name="usuario"></param>
    /// <param name="contrasena"></param>
    /// <returns></returns>
    public string ObtenerRolUsuario(string usuario, string contrasena)
    {
        List<Usuario> usuarios = CargarUsuarios();
        Usuario user = usuarios.Find(u => u.NombreUsuario.Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) && u.Contrasena == contrasena.Trim());
        return user != null ? user.Rol : "Usuario o contraseña incorrectos";
    }

    /// <summary>
    /// Cargar y Guardar
    /// </summary>
    /// <returns></returns>
    public static List<Usuario> CargarUsuarios()
    {
        if (!File.Exists(rutaArchivo)) return new List<Usuario>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
    }

    /// <summary>
    /// Guardar usuario
    /// </summary>
    /// <param name="usuarios"></param>
    public static void GuardarUsuarios(List<Usuario> usuarios)
    {
        string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }

    /// <summary>
    /// Agregar usuario (por parámetros separados)
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="contrasena"></param>
    /// <param name="rol"></param>
    /// <param name="especialidad"></param>
    /// <param name="numeroCaja"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void AgregarUsuario(string nombre, string contrasena, string rol, string especialidad = null, int numeroCaja = 0)
    {
        List<Usuario> usuarios = CargarUsuarios();

        int nuevoId = usuarios.Any() ? usuarios.Max(u => u.IdUsuario) + 1 : 1; //Para calcular el id del usuario

        Usuario nuevoUsuario;

        switch (rol)
        {
            case "Administrador":
                nuevoUsuario = new Administrador
                {
                    IdUsuario = nuevoId,
                    NombreUsuario = nombre.Trim(),
                    Contrasena = contrasena.Trim(),
                    Rol = rol
                };
                break;

            case "Cajero":
                nuevoUsuario = new Cajero
                {
                    IdUsuario = nuevoId,
                    NombreUsuario = nombre.Trim(),
                    Contrasena = contrasena.Trim(),
                    Rol = rol,
                    NumeroDeCaja = numeroCaja
                };
                break;

            case "Tecnico":
                nuevoUsuario = new Tecnico
                {
                    IdUsuario = nuevoId,
                    NombreUsuario = nombre.Trim(),
                    Contrasena = contrasena.Trim(),
                    Rol = rol,
                    Especialidad = especialidad
                };
                break;

            default:
                throw new ArgumentException("Rol no válido");
        }

        usuarios.Add(nuevoUsuario);
        GuardarUsuarios(usuarios);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nuevo"></param>
    /// <exception cref="ArgumentNullException"></exception>
    
    public static void AgregarUsuario(Usuario nuevo)
    {
        if (nuevo == null) throw new ArgumentNullException(nameof(nuevo));

        List<Usuario> usuarios = CargarUsuarios();

        // Asignar Id único
        int nuevoId = usuarios.Any() ? usuarios.Max(u => u.IdUsuario) + 1 : 1;
        nuevo.IdUsuario = nuevoId;

        usuarios.Add(nuevo);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
        };

        File.WriteAllText(rutaArchivo, JsonSerializer.Serialize(usuarios, options));
    }
}
