﻿using System;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public Cliente(int idCliente, string nombre, string direccion, string telefono, string email)
	{
        this.IdCliente = idCliente;
        this.Nombre = nombre;   
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.Email = email; 
	}
}
