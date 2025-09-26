using System.Text.Json;

/// <summary>
/// Clase equipo osea Lavadora, heladera o cocina
/// </summary>
public sealed class Equipo
{
    //Ruta archivo
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "equipos.json");

    //Propiedades
    public int IdEquipo { get; set; }
    public string TipoDeEquipo { get; set; }
    public string Modelo { get; set; }
    public string NumeroDeSerie { get; set; }
    public string DescripcionDelProblema { get; set; }

    public static int NumeroIdEquipo = 0;
    public static List<Equipo> ListaEquipos = new List<Equipo>();

    public string InformacionEquipo => $"{TipoDeEquipo} - {Modelo} ({NumeroDeSerie})";

    /// <summary>
    /// Constructor de la clase
    /// </summary>
    public Equipo() { }

    /// <summary>
    /// Constructor de la clase sobrecargado
    /// </summary>
    /// <param name="tipo">Tipo de equipo</param>
    /// <param name="modelo">Modelo del equipo</param>
    /// <param name="numeroSerie">Numero de serie del equipo</param>
    /// <param name="descripcion">Descripcion del problema que tiene el equipo</param>
    public Equipo(string tipo, string modelo, string numeroSerie, string descripcion)
    {
        IdEquipo = ++NumeroIdEquipo;
        TipoDeEquipo = tipo;
        Modelo = modelo;
        NumeroDeSerie = numeroSerie;
        DescripcionDelProblema = descripcion;
    }

    /// <summary>
    /// Registrar y guardar en JSON
    /// </summary>
    /// <param name="tipo">Tipo de equipo</param>
    /// <param name="modelo">Modelo del equipo</param>
    /// <param name="numeroSerie">Numero de serie del equipo</param>
    /// <param name="descripcion">Descripcion del problema que tiene el equipo</param>
    /// <returns>Retorna el nuevo equipo con un nuevo id</returns>
    public static Equipo RegistrarEquipo(string tipo, string modelo, string numeroSerie, string descripcion)
    {
        ListaEquipos = CargarEquipos();
        int nuevoId = ListaEquipos.Any() ? ListaEquipos.Max(e => e.IdEquipo) + 1 : 1;

        Equipo nuevo = new Equipo(tipo, modelo, numeroSerie, descripcion)
        {
            IdEquipo = nuevoId
        };

        ListaEquipos.Add(nuevo);
        GuardarEquipos(ListaEquipos);

        return nuevo;
    }

    /// <summary>
    /// Metodo para cargar los usuario dentro de un objeto
    /// </summary>
    /// <returns>Retorna la lista de equipos para ser cargados</returns>
    public static List<Equipo> CargarEquipos()
    {
        if (!File.Exists(rutaArchivo)) return new List<Equipo>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Equipo>>(json) ?? new List<Equipo>();
    }

    /// <summary>
    /// Metodo para guardar equipos en el archivo json
    /// </summary>
    /// <param name="equipos">Lista de equipos para guardar</param>
    public static void GuardarEquipos(List<Equipo> equipos)
    {
        string json = JsonSerializer.Serialize(equipos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
