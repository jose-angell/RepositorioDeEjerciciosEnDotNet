using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2006. Count Number of Pairs With Absolute Difference K
 * Dado un array de enteros nums y un entero k, devuelve el número de pares de índices (i, j) donde i < j y |nums[i] - nums[j]| == k.
 * Input: nums = [1,2,2,1], k = 1
 * Output: 4
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 1. Crear un diccionario para contar la frecuencia de cada número en el array nums.
 * 2. Inicializar una variable c para contar el número de pares con la diferencia absoluta k.
 * 3. Recorrer cada número i en el array nums:
 *    - Si el número i - k existe en el diccionario, entonces se han encontrado pares de números con la diferencia absoluta k. En este caso, se incrementa c por la frecuencia del número i - k en el diccionario (c += dic[i - k]).
 *    - Si el número i + k existe en el diccionario, entonces también se han encontrado pares de números con la diferencia absoluta k. En este caso, se incrementa c por la frecuencia del número i + k en el diccionario (c += dic[i + k]).
 * 4. Después de verificar los pares con la diferencia absoluta k, se agrega el número i al diccionario y se incrementa su frecuencia (dic[i]++).
 * 5. Finalmente, se retorna el valor de c, que representa el número total de pares con la diferencia absoluta k.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class CountNumberofPairAbsoluteDiffK_2006
    {
        public int CountKDifference(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            int c = 0;
            foreach (int i in nums)
            {
                if (dic.ContainsKey(i - k))
                {
                    c += dic[i - k];
                }
                if (dic.ContainsKey(i + k))
                {
                    c += dic[i + k];
                }
                dic.TryAdd(i, 0);
                dic[i]++;
            }
            return c;
        }
    }
}
