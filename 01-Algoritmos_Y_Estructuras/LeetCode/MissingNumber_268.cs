using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 268. Missing Number
 * Dado un array nums que contiene n números distintos en el rango [0, n], retornar el número que falta en el array.
 * 
 * Input: nums = [3,0,1]
 * Output: 2
 * 
 * Solucion O(n) y espacio O(n)
 * 1. Crear un hashset con los números del array
 * 2. Recorrer los números del 0 al n y verificar si cada número está en el hashset, si no está, retornar ese número
 * 3. Si se recorren todos los números y no se encuentra el número faltante, retornar -1
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MissingNumber_268
    {
        public int MissingNumber(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            for (int i = 0; i <= nums.Length; i++)
            {
                if (!hash.Contains(i)) return i;
            }
            return -1;
        }
        public int MissingNumber2(int[] nums)
        {
            int n = nums.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + nums[i];
            }
            n = (n * (n + 1)) / 2;
            return n - sum;
        }
    }
}
