/*
 * Created by SharpDevelop.
 * User: Josman
 * Date: 18/10/2026
 * Time: 10:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PokeElemental
{
	/// <summary>
	/// Description of MovimientoCuracion.
	/// </summary>
public class MovimientoCuracion : Movimiento  
{
    private int cantidad;

    public MovimientoCuracion(string nombre, Tipo tipo, int ppMaximo, int cantidad)
        : base(nombre, tipo, ppMaximo)           
    {
        this.cantidad = cantidad;
    }

    public int Cantidad
    {
        get { return cantidad; }
    }

    public override string Ejecutar(Criatura usuario, Criatura objetivo)
    {
    	usuario.Curar(cantidad);
    	return usuario.Nombre + " uso " + Nombre + ". !Recupero " + cantidad.ToString() +" de vida!";
    }
}
}
