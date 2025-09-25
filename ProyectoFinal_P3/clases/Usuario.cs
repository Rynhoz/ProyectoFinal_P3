using System.Text.Json;
using ProyectoFinal_P3.clases;

public class Usuario : IAuntenticable
{
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");

    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string Contrasena { get; set; }
    public string Rol { get; set; }

    public static int NumeroIdUsuario = 0;

    public Usuario() { }

    // 🔹 Comparaciones de usuarios
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

    // 🔹 Validación de login
    public bool ValidarContrasena(string usuario, string contrasena)
    {
        List<Usuario> usuarios = CargarUsuarios();
        return usuarios.Exists(u =>
            u.NombreUsuario.Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) &&
            u.Contrasena == contrasena.Trim()
        );
    }

    // 🔹 Obtener Rol
    public string ObtenerRolUsuario(string usuario, string contrasena)
    {
        List<Usuario> usuarios = CargarUsuarios();
        Usuario user = usuarios.Find(u => u.NombreUsuario.Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) && u.Contrasena == contrasena.Trim());
        return user != null ? user.Rol : "Usuario o contraseña incorrectos";
    }

    // 🔹 Cargar y Guardar
    public static List<Usuario> CargarUsuarios()
    {
        if (!File.Exists(rutaArchivo)) return new List<Usuario>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
    }

    public static void GuardarUsuarios(List<Usuario> usuarios)
    {
        string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }

    // 🔹 Agregar usuario genérico (por parámetros separados)
    public static void AgregarUsuario(string nombre, string contrasena, string rol, string especialidad = null, int numeroCaja = 0)
    {
        List<Usuario> usuarios = CargarUsuarios();

        // Calcular el nuevo Id
        int nuevoId = usuarios.Any() ? usuarios.Max(u => u.IdUsuario) + 1 : 1;

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
