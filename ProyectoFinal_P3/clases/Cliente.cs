using System.Text.Json;

/// <summary>
/// Clase cliente para registrar clientes
/// </summary>
public sealed class Cliente
{
    //ruta del archivo
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "clientes.json");
     // propiedades
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public Equipo Equipo { get; set; }

    public static int NumeroIdCliente = 0;
    public static List<Cliente> ListaClientes = new List<Cliente>();

    /// <summary>
    /// Metodo para registrar cliente dentro de una lista
    /// </summary>
    /// <param name="nombre">Nombre del cliente</param>
    /// <param name="direccion">Direccion del cliente</param>
    /// <param name="telefono">Telefono del cliente</param>
    /// <param name="email">Correo del cliente </param>
    /// <param name="equipo">Equipo del cliente</param>
    /// <returns>Rertorna el cliente registrado en la lista</returns>
    public static Cliente RegistrarCliente(string nombre, string direccion, string telefono, string email, Equipo equipo)
    {
        ListaClientes = CargarClientes();
        int nuevoId = ListaClientes.Any() ? ListaClientes.Max(c => c.IdCliente) + 1 : 1;

        Cliente nuevo = new Cliente
        {
            IdCliente = nuevoId,
            Nombre = nombre,
            Direccion = direccion,
            Telefono = telefono,
            Email = email,
            Equipo = equipo
        };

        ListaClientes.Add(nuevo);
        GuardarClientes(ListaClientes);

        return nuevo;
    }

    /// <summary>
    /// Metodo para cargar los clientes
    /// </summary>
    /// <returns>Retorna una lista de clientes para mostrarse en la interfaz</returns>
    public static List<Cliente> CargarClientes()
    {
        if (!File.Exists(rutaArchivo)) return new List<Cliente>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();
    }

    /// <summary>
    /// Metodo para guardar clientes dentro del archivo json
    /// </summary>
    /// <param name="clientes">Lista de clientes que se van a añadir a el archivo json</param>
    public static void GuardarClientes(List<Cliente> clientes)
    {
        string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
