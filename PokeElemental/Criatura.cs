/*
 * Created by SharpDevelop.
 * User: Steffany
 * Date: 10/16/2026
 * Time: 11:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PokeElemental
{
	/// <summary>
	/// Description of Criatura.
	/// </summary>
	public class Criatura
	{
		private string nombre;
	    private Tipo tipo;
	    private int vidaMaxima;
	    private int vidaActual;
		
		public Criatura(string nombre,Tipo tipo,int vidaMaxima)
		{
			this.nombre = nombre;
			this.tipo = tipo;
			this.vidaMaxima = vidaMaxima;
			vidaActual = vidaMaxima;
		}
		public string Nombre
		{
			get{ return nombre;}
		}
		public Tipo Tipo
		{
			get{ return tipo;}
		}
		public int VidaMaxima
		{
			get{ return vidaMaxima;}
		}
		public int VidaActual
		{
			get{ return vidaActual;}
		}
		public void RecibirDano(int cantidad)
		{
			vidaActual-=cantidad;
			if(vidaActual<0)
			{
				vidaActual=0;
			}
		}
		public void Curar(int cantidad)
		{
			vidaActual+=cantidad;
			if(vidaActual>vidaMaxima)
			{
				vidaActual=vidaMaxima;
			}
		}
	}
}
