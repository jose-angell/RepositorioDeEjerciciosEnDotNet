using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1512 Number of Good Pairs
 * dado un array de enteros encuentra el numero total de pares (i,j) que se pueden generar donde el numero sea igual y que el indice i sea menor a j 
 * 
 * Solucion
 * 1. generar un diccionario con las frecuencias de cada numero en el array
 * 2. crear una variable para guardar la suma final
 * 3. recorrer el array original
 * 4. cada numero del array es una clave en el diccionario ,y si el valor es mayor a 1, se entra en la condicional, para restarle uno al valor acumulado y despues sumarlo al resultado
 * 5.devolver la suma final.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class NumberOfGppdPairs_1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.TryAdd(nums[i], 0);
                dic[nums[i]] += 1;
            }
            int c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic[nums[i]] > 1)
                {
                    dic[nums[i]] -= 1;
                    c += dic[nums[i]];
                }
            }
            return c;
        }
    }
}
