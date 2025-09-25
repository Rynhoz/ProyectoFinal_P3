using System.Text.Json;

public class Cliente
{
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "clientes.json");

    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public Equipo Equipo { get; set; }

    public static int NumeroIdCliente = 0;
    public static List<Cliente> ListaClientes = new List<Cliente>();

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

    public static List<Cliente> CargarClientes()
    {
        if (!File.Exists(rutaArchivo)) return new List<Cliente>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();
    }

    public static void GuardarClientes(List<Cliente> clientes)
    {
        string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
