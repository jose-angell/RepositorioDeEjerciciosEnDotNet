using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1394. Find Lucky Integer in an Array
 *  Dado un arreglo de enteros arr, regresa el entero de la suerte más grande en el arreglo. Un entero de la suerte es un entero que tiene exactamente ese número de ocurrencias en el arreglo.
 *  input: arr = [1,2,3,3,3]
 *  output: 3
 *  Solucion: O(n)
 *  1. Crear un diccionario para contar las ocurrencias de cada entero en el arreglo.
 *  2. Recorrer el arreglo y actualizar el conteo de cada entero en el diccionario.
 *  3. Recorrer el diccionario para encontrar el entero de la suerte más grande, verificando si la clave es igual al valor (número de ocurrencias) y actualizando el máximo encontrado.
 *  4. Regresar el entero de la suerte más grande encontrado, o -1 si no se encuentra ninguno.
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class FindLuckyIntegerInAnArray_1394
    {
        public int FindLucky(int[] arr)
        {
            var dic = new Dictionary<int, int>();
            int max = -1;
            foreach (int i in arr)
            {
                dic.TryAdd(i, 0);
                dic[i] += 1;
            }
            foreach (var k in dic)
            {
                if (k.Key == k.Value && k.Value > max)
                {
                    max = k.Value;
                }
            }
            return max;
        }
    }
}
