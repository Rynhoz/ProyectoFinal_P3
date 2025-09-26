using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

/// <summary>
/// clase Repuesto
/// </summary>
public sealed class Repuesto
{
    //Propiedades
    public int IdRepuesto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Familia { get; set; }
    public decimal Stock { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal PrecioVenta { get; set; }

    public static List<Repuesto> ListaRepuestos = new List<Repuesto>();
    private static int contadorId = 0;
    private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivosJson", "inventario.json");

    /// <summary>
    /// Constructor de la clase
    /// </summary>
    public Repuesto() { }

    /// <summary>
    /// Constructor de la clase spbrcargado 
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="descripcion"></param>
    /// <param name="familia"></param>
    /// <param name="stock"></param>
    /// <param name="precioUnitario"></param>
    public Repuesto(string nombre, string descripcion, string familia, decimal stock, decimal precioUnitario)
    {
        IdRepuesto = ++contadorId;
        Nombre = nombre;
        Descripcion = descripcion;
        Familia = familia;
        Stock = stock;
        PrecioUnitario = precioUnitario;
    }

    /// <summary>
    /// Metodo para que se pueda registrar Repuestos dentro de una lista
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="descripcion"></param>
    /// <param name="familia"></param>
    /// <param name="stock"></param>
    /// <param name="precioUnitario"></param>
    /// <returns>Retorna el repuesto pero ya añadido a la lista global de repuestos</returns>
    public static Repuesto RegistrarRepuesto(string nombre, string descripcion, string familia, decimal stock, decimal precioUnitario)
    {
        ListaRepuestos = CargarRepuestos(); // recargar para no perder datos
        Repuesto nuevo = new Repuesto(nombre, descripcion, familia, stock, precioUnitario);
        ListaRepuestos.Add(nuevo);
        GuardarRepuestos(ListaRepuestos);
        MessageBox.Show($"Repuesto registrado correctamente\nID: {nuevo.IdRepuesto}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }

    /// <summary>
    /// Metodo que carga los repuestos
    /// </summary>
    /// <returns>Retorna la lista de repuestos que se van a cargar</returns>
    public static List<Repuesto> CargarRepuestos()
    {
        if (!File.Exists(rutaArchivo)) return new List<Repuesto>();
        string json = File.ReadAllText(rutaArchivo);
        // Actualiza contadorId para no repetir IDs
        ListaRepuestos = JsonSerializer.Deserialize<List<Repuesto>>(json) ?? new List<Repuesto>();
        if (ListaRepuestos.Any())
            contadorId = ListaRepuestos.Max(r => r.IdRepuesto);
        return ListaRepuestos;
    }

    /// <summary>
    /// Metodo para guardar los repuestos en el archivo json
    /// </summary>
    /// <param name="repuestos"></param>
    public static void GuardarRepuestos(List<Repuesto> repuestos)
    {
        string json = JsonSerializer.Serialize(repuestos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
