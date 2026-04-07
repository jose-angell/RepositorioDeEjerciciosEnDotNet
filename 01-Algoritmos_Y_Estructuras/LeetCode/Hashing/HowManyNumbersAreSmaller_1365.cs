using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1365. How Many Numbers Are Smaller Than the Current Number
 * Dado un array de numeros enteros, retornar un array donde cada elemento es el numero de elementos en el array original que son menores que el elemento en esa posicion.
 * Input: nums = [8,1,2,2,3]
 * Output: [4,0,1,1,3]
 * 
 * Solucinon: O(n^2) y espacion O(n)
 * 1. Crear un diccionario para almacenar el numero de elementos menores que cada numero en el array original, donde la clave es el numero y el valor es el conteo de elementos
 * 2. Crear un array para guardar la respuesta, con el tamano del array de entrada
 * 3. Recorrer el array original, para cada elemento, contar el numero de elementos menores que ese elemento y almacenar el conteo en el diccionario, si el numero ya se encuentra en el diccionario, continuar con el siguiente elemento
 * 4. Recorrer el array original nuevamente, para cada elemento, obtener el conteo de elementos menores que ese elemento del diccionario y almacenarlo en el array de respuesta
 * 5. Retornar el array de respuesta
 * 
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class HowManyNumbersAreSmaller_1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                if (dict.ContainsKey(nums[i]))
                {
                    continue;
                }
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        sum += 1;
                    }
                }
                dict.Add(nums[i], sum);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = dict[nums[i]];
            }
            return res;
        }
        /* solucion O(n) y espacio O(1)
         * 1. crar un array de conteo para almacenar el numero de veces que cada numero aparece en el array original, se inicializa en 101 para cubrir el rango de numeros enteros de 0 a 100
         * 2. recorrer el array original, para cada elemento, incrementar el conteo en el array de conteo en la posicion correspondiente al numero
         * 3. recorrer el array de conteo, para cada posicion, sumar el conteo de la posicion anterior para obtener el conteo acumulado de numeros menores que el numero en esa posicion
         * 4. recorrer el array original nuevamente, 
         * 5. para cada elemento, se asigna en la posicion actual del array original el conteo acumulado de numeros menores que ese elemento, que se encuentra en la posicion correspondiente al numero menos uno en el array de conteo, si el numero es cero, se asigna cero
         * 6. retornar el array original, que ahora contiene el conteo de numeros menores que cada elemento en la posicion correspondiente
         * 
         */
        public int[] SmallerNumbersThanCurrent2(int[] nums)
        {
            int[] count = new int[101];
            foreach (int n in nums)
            {
                ++count[n];
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) nums[i] = count[nums[i] - 1];
            }
            return nums;
        }
    }
}
