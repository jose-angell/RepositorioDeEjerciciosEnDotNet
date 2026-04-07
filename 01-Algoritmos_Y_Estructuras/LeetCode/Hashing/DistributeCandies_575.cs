using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 575 Distribute Candies
 * Dado un array de numeros que representran los dulces y sus diferentes tipos, encontrar la maxima variedad de dulces que se pueden comer si solo se pueden comer n / 2,
 * donde n es el tamano del array
 * 
 * solucion: O(1), espacio O(n)
 * 1. creo un hashset de los tipos de dulces 
 * 2. calculo cuanto es n / 2
 * 3. valido si (n/2) es mayor que la cantidad de tipos de dulces regreso la cantidad de tipos
 * 4. si es menor regreso (n/2) porque ese seria el maximo valor
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class DistributeCandies_575
    {
        public int DistributeCandies(int[] candyType)
        {
            var candySet = new HashSet<int>(candyType);
            int n = candyType.Length;
            int midN = n / 2;
            if (midN > candySet.Count())
            {
                return candySet.Count();
            }
            else
            {
                return midN;
            }
        }
    }
}
