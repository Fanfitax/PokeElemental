/*
 * Created by SharpDevelop.
 * User: Steffany
 * Date: 10/18/2026
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PokeElemental
{
	/// <summary>
	/// Description of Movimiento.
	/// </summary>
	public abstract class Movimiento
{
    private string nombre;
    private Tipo tipo;
    private int ppMaximo;
    private int ppActual;

    public Movimiento(string nombre, Tipo tipo, int ppMaximo)
    {
    	this.nombre = nombre;
    	this.tipo = tipo;
    	this.ppMaximo = ppMaximo;
    	ppActual= ppMaximo;
    }

   public string Nombre
   {
   	get{return nombre;}
   }
   public Tipo Tipo
   {
   	get {return tipo;}
   }
   public int PpMaximo
   {
   	get{ return ppMaximo;}
   }
   public int PpActual
   {
   	get{return ppActual;}
   }
   

    public void GastarPP()
    {
    	if(ppActual<0)
    	{
    		ppActual-=1;
    	}
    }

    public abstract string Ejecutar(Criatura usuario, Criatura objetivo);
}
}

