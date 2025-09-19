using System;

namespace ProyectoFinal_P3.clases
{
	internal interface IAuntenticable
	{
		bool ValidarContrasena(string contrasena);
		bool TienePermiso(string permiso);
	}
}
