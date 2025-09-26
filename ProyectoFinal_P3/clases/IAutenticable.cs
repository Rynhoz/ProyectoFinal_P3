using System;
using System.Text.Json;

namespace ProyectoFinal_P3.clases
{
	/// <summary>
	/// 
	/// </summary>
	public interface IAuntenticable
	{
		//Validad el ingreso a la app
		bool ValidarContrasena(string usuario, string contrasena);
	}
}
