using System;
using System.Text.Json;

namespace ProyectoFinal_P3.clases
{
	public interface IAuntenticable
	{
		bool ValidarContrasena(string usuario, string contrasena);
		bool TienePermiso(string permiso);
	}
}
