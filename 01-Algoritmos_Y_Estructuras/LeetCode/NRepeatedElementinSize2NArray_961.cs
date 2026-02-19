using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 961. N-Repeated Element in Size 2N Array
 * 
 * Dado un array de enteros con tamaño 2N, donde hay N+1 elementos distintos y uno de ellos se repite N veces, encontrar el elemento que se repite N veces.
 * Input: nums = [1,2,3,3]
 * Output: 3
 * 
 * Solucion: O(n) y espacio O(n)
 * 
 * 1. Inicializar un hashset para guardar los numeros que ya han aparecido
 * 2. Recorrer el array de entrada y verificar si el numero ya esta en el hashset, si esta, retornar ese numero
 * 3. Si no esta, agregar el numero al hashset
 * 4. Si se recorre todo el array sin encontrar el numero repetido, retornar 0 (aunque esto no deberia pasar segun el enunciado)
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class NRepeatedElementinSize2NArray_961
    {
        public int RepeatedNTimes(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (int n in nums)
            {
                if (!hash.Add(n))
                {
                    return n;
                }
            }
            return 0;
        }
    }
}
