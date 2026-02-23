using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 594. Longest Harmonious Subsequence
 * 
 * cuando tenemos un array de numeros enteros, una subsecuencia armoniosa es aquella donde la diferencia entre el numero mas grande y el numero mas 
 * pequeño es exactamente 1. Dado un array de numeros enteros, retornar la longitud de la subsecuencia armoniosa mas larga que se pueda encontrar en el array dado.
 * 
 * Input: nums = [1,3,2,2,5,2,3,7]
 * Output: 5
 * Solucion O(n) y espacio O(n)
 * 1. Crear un diccionario para contar la frecuencia de cada numero en el array dado
 * 2. crear una variable para almacenar la longitud de la subsecuencia armoniosa mas larga encontrada, inicializada en 0
 * 3. Recorrer el diccionario y para cada numero, verificar si el numero siguiente (numero + 1) esta presente en el diccionario
 * 4. Si el numero siguiente esta, validar si la suma de las frecuencias del numero actual y el siguiente son mayor que la longitud de la subsecuencia armoniosa mas larga encontrada, y si es asi, actualizar la longitud de la subsecuencia armoniosa mas larga encontrada
 * 5. Retornar la longitud de la subsecuencia armoniosa mas larga encontrada
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class LongestHarmoniousSubsequence_594
    {
        public int FindLHS(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                dict.TryAdd(n, 0);
                dict[n] += 1;
            }
            int max = 0;
            foreach (var d in dict)
            {
                if (dict.ContainsKey(d.Key + 1) && (d.Value + dict[d.Key + 1]) > max)
                {
                    max = d.Value + dict[d.Key + 1];
                }
            }
            return max;
        }
    }
}
