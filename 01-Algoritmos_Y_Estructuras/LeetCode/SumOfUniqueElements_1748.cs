using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1748. Sum of Unique Elements
 * Dado un array de numeros sumar todos los elementos que solo aparecen una vez y regresar la suma
 * Input: nums=[1,2,3,2]
 * Output: 4
 * 
 * Solucion: O(n) y espacion O(n)
 * 1. Inicializar un diccionario para contar la frecuencia
 * 2. Inicializar una variable para guardar la suma
 * 3. Recorrer el array de entrada y llenar el diccionario con las frecuenccias
 * 4. Recorrer el diccionario y sumar solo los que tienen un a frecuencia de uno
 * 5. Retornar la suma
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class SumOfUniqueElements_1748
    {
        public int SumOfUnique(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int sum = 0;
            foreach (int n in nums)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n] += 1;
                }
                else
                {
                    dict.Add(n, 1);
                }
            }
            foreach (var i in dict)
            {
                if (i.Value == 1)
                {
                    sum += i.Key;
                }
            }
            return sum;
        }
    }
}
