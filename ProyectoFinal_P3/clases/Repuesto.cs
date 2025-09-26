using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

/// <summary>
/// 
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
    /// 
    /// </summary>
    public Repuesto() { }

    /// <summary>
    /// 
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
    /// 
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="descripcion"></param>
    /// <param name="familia"></param>
    /// <param name="stock"></param>
    /// <param name="precioUnitario"></param>
    /// <returns></returns>
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
    /// 
    /// </summary>
    /// <returns></returns>
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
    /// 
    /// </summary>
    /// <param name="repuestos"></param>
    public static void GuardarRepuestos(List<Repuesto> repuestos)
    {
        string json = JsonSerializer.Serialize(repuestos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(rutaArchivo, json);
    }
}
