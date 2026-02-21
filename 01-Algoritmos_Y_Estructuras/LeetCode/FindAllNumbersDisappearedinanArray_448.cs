using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 448. Find All Numbers Disappeared in an Array
 * Dado un array de numeros enteros donde cada numero esta en el rango [1,n] y n es el tamaño del array, retornar un array con los numeros que no aparecen en el array dado.
 * 
 * Input: nums = [4,3,2,7,8,2,3,1]
 * Output: [5,6]
 * 
 * Soculucion O(n) y espacio O(n)
 * 
 * 1. Crear un hashset para almacenar los numeros que aparecen en el array dado
 * 2. Recorrer el rango de datos desde 1 hasta n, y verificar si cada numero esta presente en el hashset
 * 3. Si un numero no esta presente en el hashset, agregarlo a la lista de numeros que no aparecen
 * 4. Retornar la lista de numeros que no aparecen
 * 
 */


namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FindAllNumbersDisappearedinanArray_448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            List<int> notAppear = [];
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!hash.Contains(i))
                {
                    notAppear.Add(i);
                }
            }
            return notAppear;
        }

        /* Solucion O(n) y espacio O(n)
         * 1. Crear un array booleano de tamaño n+1 para marcar los numeros que aparecen en el array dado, inicializado en false
         * 2. Recorrer el array dado y marcar los numeros que aparecen en el array booleano, estableciendo el valor en true para cada numero que aparece
         * 3. Recorrer el rango de datos desde 1 hasta n, y verificar si cada numero esta marcado como true en el array booleano
         * 4. Si un numero no esta marcado como true en el array booleano, agregarlo a la lista de numeros que no aparecen
         * 5. Retornar la lista de numeros que no aparecen
         * 
         */

        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            var n = nums.Length;
            bool[] hash = new bool[n + 1];
            List<int> notAppear = [];

            for (int i =0; i <= n; i++)
            {
                hash[nums[i]] = true;
            }
            for(int i =1; i <= n; i++)
            {
                if (!hash[i])
                {
                    notAppear.Add(i);
                }
            }
            return notAppear;
        }
    }
}
