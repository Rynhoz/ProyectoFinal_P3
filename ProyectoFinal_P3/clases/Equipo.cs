using System.Text.Json;

public class Equipo
{
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "equipos.json");

    public int IdEquipo { get; set; }
    public string TipoDeEquipo { get; set; }
    public string Modelo { get; set; }
    public string NumeroDeSerie { get; set; }
    public string DescripcionDelProblema { get; set; }

    public static int NumeroIdEquipo = 0;
    public static List<Equipo> ListaEquipos = new List<Equipo>();

    public string InformacionEquipo => $"{TipoDeEquipo} - {Modelo} ({NumeroDeSerie})";

    public Equipo() { }

    public Equipo(string tipo, string modelo, string numeroSerie, string descripcion)
    {
        IdEquipo = ++NumeroIdEquipo;
        TipoDeEquipo = tipo;
        Modelo = modelo;
        NumeroDeSerie = numeroSerie;
        DescripcionDelProblema = descripcion;
    }

    // 🔹 Registrar y guardar en JSON
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

    public static List<Equipo> CargarEquipos()
    {
        if (!File.Exists(rutaArchivo)) return new List<Equipo>();
        string json = File.ReadAllText(rutaArchivo);
        return JsonSerializer.Deserialize<List<Equipo>>(json) ?? new List<Equipo>();
    }

    public static void GuardarEquipos(List<Equipo> equipos)
    {
        string json = JsonSerializer.Serialize(equipos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
