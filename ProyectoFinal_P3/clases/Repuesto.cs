using System;
using ProyectoFinal_P3.clases;

public sealed class Repuesto
{
    // Propiedades de la Clase Repuesto.
    public int IdRepuesto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Familia { get; set; }
    public int Stock { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal PrecioVenta { get; set; }

    public static List<Repuesto> ListaRepuestos = new List<Repuesto>();

    private static int contadorId = 0;
    /// <summary>
    /// Constructo de la Clase Repuesto.
    /// </summary>
    /// <param name="nombre">Nombre del repuesto.</param>
    /// <param name="descripcion">Descripción del repuesto.</param>
    /// <param name="familia">Familia a la que pertenece el repuesto.</param>
    /// <param name="stock">Existencias disponibles del repuesto.</param>
    /// <param name="precioUnitario">Precio unitario del repuesto.</param>
    public Repuesto(string nombre, string descripcion, string familia, int stock, decimal precioUnitario)
	{
        contadorId++;
        IdRepuesto = contadorId;
        Nombre = nombre;   
        Descripcion = descripcion;
        Familia = familia;
        Stock = stock;
        PrecioUnitario = precioUnitario;
	}
    /// <summary>
    /// Método que sirve para registrar un repuesto con sus respectivos datos.
    /// </summary>
    /// <param name="nombre">Nombre del repuesto.</param>
    /// <param name="descripcion">Descripción del repuesto.</param>
    /// <param name="familia">Familia a la que pertenece el repuesto.</param>
    /// <param name="stock">Existencias disponibles del repuesto.</param>
    /// <param name="precioUnitario">Precio unitario del repuesto.</param>
    /// <returns></returns>
    public static Repuesto RegistrarRepuesto(string nombre, string descripcion, string familia, int stock, decimal precioUnitario)
    {
        // nuevo es una instancia de la clase Repuesto almacenada en una variable local dentro del método.
        Repuesto nuevo = new Repuesto(nombre, descripcion, familia, stock, precioUnitario);
        ListaRepuestos.Add(nuevo);
        MessageBox.Show($"Repuesto registrado correctamente\nID: {nuevo.IdRepuesto}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return nuevo;
    }
    /// <summary>
    /// Método que sirve para eliminar un repuesto.
    /// </summary>
    /// <param name="idRepuesto">ID del objeto a borrar</param>
    /// <returns></returns>
    public static bool EliminarRepuesto(int idRepuesto)
    {
        // Buscar el repuesto por ID en la lista
        Repuesto repuesto = ListaRepuestos.Find(id => id.IdRepuesto == idRepuesto);

        if (repuesto != null)
        {   
            // Guarda el repuesto a eliminar 
            Registro nuevoRegistro = new Registro(repuesto);
            // Si lo encuentra, lo elimina e indica que se eliminó
            ListaRepuestos.Remove(repuesto);
            MessageBox.Show("Repuesto eliminado correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true; 
        }
        else
        {   // No se eliminó nada
            MessageBox.Show("No se encontró el repuesto con ese Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false; 
        }
    }   
}


