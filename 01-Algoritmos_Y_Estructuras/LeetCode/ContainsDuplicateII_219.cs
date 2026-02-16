using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 219. Contains Duplicate II
 * Dado un array de numeros nums y un numero k, regresar true si existe el mismo numero en dos distintos indices y al mismo tiempo el valor absoluto de la diferencia de los
 * indices sea menor o igual a k.
 * Imput: nums = [1,2,3,1], k = 3
 * Output: true
 * 
 * Solucion: O(n) y espacion O(n)
 * 1. Inicializar un diccionario para almacenar el valor del array como llave y su indice como valor
 * 2. recorrer el array con un ciclo for
 * 3. Validar si ya existe el numero en el dicccionario
 *    - validar si el valor absoluto de la diferencia del indice guardado en el diccionario y el actual son menor a k, se returna true
 *    - si no es menor el valor del indice se actualiza al actual
 * 4. si no existe se agrega con el indice como el valor
 * 5. si el ciclo termina retornar false, 
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ContainsDuplicateII_219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (Math.Abs((dict[nums[i]] - i)) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return false;
        }
    }
}
