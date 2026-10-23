using System;
using System.Collections.Generic;

namespace PokeElemental
{
    public class TablaTipos
    {
        private static Dictionary<Tipo, Tipo> ventajas = new Dictionary<Tipo, Tipo>();

        static TablaTipos()
        {
            ventajas.Add(Tipo.Agua, Tipo.Fuego);
            ventajas.Add(Tipo.Fuego, Tipo.Aire);
            ventajas.Add(Tipo.Aire, Tipo.Tierra);
            ventajas.Add(Tipo.Tierra, Tipo.Agua);
        }

        public static double ObtenerMultiplicador(Tipo atacante, Tipo defensor)
        {
        	if(ventajas[atacante] == defensor)
        	{
        		return 1.5;
        	}
        	if (ventajas[defensor] == atacante)
        	{
        		return 0.5;
        	}
        	else
        	{
        		return 1.0;
        	}
        }
    }
}

