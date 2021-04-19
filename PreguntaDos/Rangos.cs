using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PreguntaDos
{
    public class Rangos
    {
        public int[]  CompletarRango(int[]  request)
        {

            int max = request.Max();
            int min = request.Min();

            int indice = max - min;

            int[] nuevoRango= new int[indice+1];
            int contador = 0;

            for (int i = min; i <= max; i++)
            {
                
                nuevoRango[contador] = i;
                contador = contador + 1;
            }
          
            return nuevoRango;
        }
    }
}
