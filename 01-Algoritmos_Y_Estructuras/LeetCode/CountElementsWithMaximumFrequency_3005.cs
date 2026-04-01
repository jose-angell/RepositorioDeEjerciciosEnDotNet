using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3005 Count Elements With Maximum Frequency
 * Dado un array de enteros nums, encontrar el número de elementos que tienen la frecuencia máxima en el array.
 * Input: nums = [1,2,2,3,3,3]
 * Output: 3
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 1. crear y llenar un diccionario para contar la frecuencia de cada número en el array nums.
 * 2. inicializar dos variables, max para almacenar la frecuencia máxima encontrada y count para contar el número de elementos que tienen esa frecuencia máxima.
 * 3. Recorrer el diccionario para comparar la frecuencia de cada número con la frecuencia máxima actual.
 *    Si la frecuencia de un numero es mayor que max, actualizar max con esa frecuencia y resetear contador con esa frecuencia.
 *    Si la frecuencia de un numero es igual a max, incrementar el contador en esa frecuencia.
 * 4. Retornar el contador como resultado, que representa el número de elementos con la frecuencia máxima en el array nums.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class CountElementsWithMaximumFrequency_3005
    {
        public int MaxFrequencyElements(int[] nums)
        {
            var d = new Dictionary<int, int>();
            int c = 0;
            foreach (int n in nums)
            {
                d.TryAdd(n, 0);
                d[n] += 1;
            }
            int max = 1;
            foreach (var n in d)
            {
                if (n.Value > max)
                {
                    c = n.Value;
                    max = n.Value;
                }
                else if (n.Value == max)
                {
                    c += max;
                }
            }
            return c;
        }
    }
}
