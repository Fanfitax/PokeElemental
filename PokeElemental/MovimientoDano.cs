/*
 * Created by SharpDevelop.
 * User: Steffany
 * Date: 10/18/2026
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PokeElemental
{
	/// <summary>
	/// Description of MovimientoDano.
	/// </summary>
	public class MovimientoDano : Movimiento
{
    private int poder;

    public MovimientoDano(string nombre, Tipo tipo, int ppMaximo, int poder)
        : base(nombre, tipo, ppMaximo)
    {
        this.poder = poder;
    }

    public int Poder
    {
    	get{return poder;}
    }
    

    public override string Ejecutar(Criatura usuario, Criatura objetivo)
    {
    	double multiplicador = TablaTipos.ObtenerMultiplicador(Tipo, objetivo.Tipo);
    	int dano = (int)(poder * multiplicador);
    	objetivo.RecibirDano(dano);
    	string mensaje = usuario.Nombre + " uso " + Nombre + ". !Hizo " + dano.ToString() + " de dano!";
    	if(multiplicador> 1)
    	{
    		return mensaje += " Es muy efectivo!";
    	}
    	if (multiplicador<1)
    	{
    		return mensaje += " No es muy efectivo!";
    	}
    	else if
    	{
    	return mensaje;
    	}
    }
}
}