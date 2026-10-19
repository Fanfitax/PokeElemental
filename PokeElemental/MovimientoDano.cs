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
    	objetivo.RecibirDano(poder);
    	return usuario.Nombre + " uso " + Nombre + ". !Hizo " + poder.ToString() + " De dano!";
    		
    }
}
}