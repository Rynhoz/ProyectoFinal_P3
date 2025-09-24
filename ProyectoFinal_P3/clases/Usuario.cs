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

    /// <summary>
    /// Metodo que verifica si el usuario existe y si ingreso bien sus datos para ingresar a la aplicacion
    /// </summary>
    /// <param name="usuario">Nombre del usuario</param>
    /// <param name="contrasena">Contraseña del usuario</param>
    /// <returns>Retorna un booleano para confirmar si existe o no el usuario</returns>
    /// <exception cref="FileNotFoundException"></exception>
    public bool ValidarContrasena(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");
        }

        string json = File.ReadAllText(rutaArchivo);

        // Deserializar Json y asegurar que nunca sea null, coloca los nombres del json en para que sean de tipo usuario
        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

        // Buscar coincidencia
        return usuarios.Exists(u =>
            u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
            u.Contrasena == contrasena
        );
    }

    /// <summary>
    /// Metodo que Obtiene el rol del usuario para verfificar que permisos tiene en la aplicacion
    /// </summary>
    /// <param name="usuario">Nombre del usuairo</param>
    /// <param name="contrasena">Contraseña del Usuario</param>
    /// <returns>Retorna el Rol del usuario ingresado</returns>
    /// <exception cref="FileNotFoundException"></exception>
    public string ObtenerRolUsuario(string usuario, string contrasena)
    {
        if (!File.Exists(rutaArchivo))
        {
            throw new FileNotFoundException($"No se encontró el archivo en {rutaArchivo}");
        }

        string json = File.ReadAllText(rutaArchivo);

        // Deserializar Json y asegurar que nunca sea null, coloca los nombres del json en para que sean de tipo usuario
        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

        // Buscar usuario que coincida
        Usuario user = usuarios.Find(u =>
            u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
            u.Contrasena == contrasena
        );

        if (user == null)
        {
            return "Usuario o contraseña incorrectos";
        }

        // Verificar que el rol sea uno de los permitidos
        return (user.Rol == "Administrador" || user.Rol == "Cajero" || user.Rol == "Técnico") ? user.Rol: "Rol no válido";
    }

    public static List<Usuario> CargarUsuarios()
    {
        //    Construimos la ruta completa del archivo "usuarios.json
        //    usando la carpeta "archivosJson" dentro del directorio base de la aplicación.
        string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "usuarios.json");


        //  Preguntamos si el archivo existe en esa ruta
        if (!File.Exists(rutaArchivo))
        {   
         // Si no existe devolvemos una lista vacia
            return new List<Usuario>(); 
        }

        // Leemos el contenido del archivo JSON como texto
        string json = File.ReadAllText(rutaArchivo);

        //   
        // Deserializamos el JSON y lo convertimos en una lista de objetos Usuario, si devuelve null devolvemos una lista vacia
        return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
    }

}
