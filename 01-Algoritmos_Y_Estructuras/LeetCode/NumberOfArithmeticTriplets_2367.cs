using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2367. Number of Arithmetic Triplets
 * Dado un array de enteros nums y un entero diff, contar el numero de tripletas aritmeticas en nums. Una tripleta (i, j, k) es aritmetica si i < j < k y nums[j] - nums[i] == diff y nums[k] - nums[j] == diff.
 * Input: nums = [0,1,4,6,7,10], diff = 3
 * Output: 2
 * para resolver este problema se puede utilizar una solucion maatematica,
 * considerando que a = nums[i], b = nums[j] y c = nums[k],
 * se puede decir que la distancia entre a y b es diff, y la distancia entre b y c es diff, por lo tanto, se puede escribir la siguiente ecuacion:\
 * a + diff = b = c - diff ; ya que para llegar a b se nececita un numero diff mayor que a, y para llegar a c se necesita un numero diff mayor que b, por lo tanto, se puede escribir la siguiente ecuacion:\
 * a + diff = b 
 * c - diff = b
 * haciendo la suposicion de que en mi algoritmo siempre estare en b, entonces, se puede escribir la siguiente ecuacion:\
 * a = b - diff
 * c = b + diff
 * entonces si en el array se encuentra a y c, cuando estoy en b, quiere decir que encontre una tripleta
 * 
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 
 * 1. Crear un HashSet para almacenar los elementos del array nums, lo que permitirá realizar búsquedas en O(1) tiempo.
 * 2. Inicializar un contador para contar el número de tripletas aritméticas encontradas.
 * 3. Recorrer el array nums utilizando, para cada elemento nums[i], validar si el numero nums[i] - diff y nums[i] + diff existen en el HashSet.
 *    Si ambos existen, significa que se ha encontrado una tripleta aritmética (nums[i] - diff, nums[i], nums[i] + diff), por lo que se incrementa el contador.
 * 4. Retornar el contador como resultado, que representará el número de tripletas aritméticas encontradas en el array nums.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class NumberOfArithmeticTriplets_2367
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            var s = new HashSet<int>(nums);
            int r = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (s.Contains(nums[i] - diff) && s.Contains(nums[i] + diff))
                {
                    r++;
                }
            }
            return r;
        }
    }
}
