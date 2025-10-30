using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Two Sum
/* Objetivo: teniendo como entrada un array de numeros enteros (nums) encontrar la posiscion de los 
 * dos valores sumados sean igual al valor objetivo (target)
 * Entrada :
 *  nums -> array de numeros enteros 
 *  target -> valor a encontrar al sumar los valores del array
 *  
 *  Nota: cada entrada tendra exactamente una solucion y no se puede usar el mismo elemento dos veces
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            // Crear un diccionario para almacenar los numeros del array como key y sus indices como value
            var pairs = new Dictionary<int, int>();
            // Recorrer el array de numeros
            for( int i = 0; i < nums.Length; i++)
            {
                // verifico si el valor complementario (el valor de target menos el valor actual del array) existe en el diccionrio
                if(pairs.ContainsKey(target - nums[i]))
                { // si existe retorno un array con los indices de los dos valores que sumados dan el target
                    return new int[] { pairs[target - nums[i]], i };
                }
                else
                { // si no existe agrego el valor actual del array y su indice al diccionario
                    pairs[nums[i]] = i;
                }
            }
            // si no se encuentra ninguna pareja qeu sume el target retorno un array vacio
            return [];
        }
    }
}
