using System;

public class Tecnico : Usuario
{
	public string Especialidad { get; set; }
    public List<OrdenDeTrabajo> OrdenesAsignadas { get; set; }

    public Tecnico(string especialidad)
	{
		this.Especialidad = especialidad;
        this.OrdenesAsignadas = new List<OrdenDeTrabajo>();
    }
}
