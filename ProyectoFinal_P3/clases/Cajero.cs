using System;

public class Cajero : Usuario
{
    public int NumeroDeCaja { get; set; }

    public Cajero(int numeroDeCaja)
	{
        this.NumeroDeCaja = numeroDeCaja;
	}
}
