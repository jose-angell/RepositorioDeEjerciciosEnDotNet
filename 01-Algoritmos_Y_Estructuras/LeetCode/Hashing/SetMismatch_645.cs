using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 645 Set Mismatch
 * Dado un array con una secuencia de numeros que van de 1 a n, existe un error donde un numero se repite y eso proboca que a la secuensia le falte otro numero
 * Input: nums = [1,2,2,4]
 * Output: [2,3]
 * 
 * Solucion: O(n), espacio O(n)
 * 
 * 1. Inicializar un diccionario para saber si todos los elementos que deberian estar en el array aparecen una vez menos o mas.
 * 2. Inivislizar dos variables para guardar el numero repetido y el numero que no se puso en el array de entrada
 * 3. Crear un for para llenar el diccionario con todos los numeros que deberia tener el array de entrada, inicializandolos con cero.
 * 4. Recorrer el array nums y usar sus valores para acceder al diccionario e incrementar en uno cada numero que esta en el diccionario
 * 5. Recorrer el dicccionario y buscar el numero que aparece mas de una vez y buscar el valor que tiene cero apariciones en el diccionario
 * 6. Tomar esos valores y retornarlos en un array
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class SetMismatch_645
    {
        public int[] FindErrorNums(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int num = 0;
            int missing = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                dict.Add(i, 0);
            }
            foreach (int n in nums)
            {
                dict[n] += 1;
            }
            foreach (var i in dict)
            {
                if (i.Value > 1)
                {
                    num = i.Key;
                }
                else if (i.Value == 0)
                {
                    missing = i.Key;
                }
            }
            return [num, missing];
        }
    }
}
