using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 2215. Find the Difference of Two Arrays
 * Dado dos arrays de enteros, encontrar los elementos que estan en el primer array pero no en el segundo y viceversa
 * Input: nums1 = [1,2,3], nums2 = [2,4,6]
 * Output: [[1,3],[4,6]]
 * 
 * Solucion: O(n) y espacio O(n)
 * 
 * 1. Inicializar dos hashsets para guardar los elementos de cada array
 * 2. Inicializar una lista de listas para guardar la respuesta
 * 3. Recorrer el primer set y agregar los elementos al primer array de la respuesta si no estan en el segundo hashset
 * 4. Recorrer el segundo set y agregar los elementos al segundo array de la respuesta si no estan en el primer hashset
 * 5. Regresar la respuesta.
 * 
 * 
 */


namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FindTheDiferentTwoArrays_2215
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);
            IList<IList<int>> answer = new List<IList<int>>{
            new List<int>(),
            new List<int>()
        };
            foreach (int n in set1)
            {
                if (!set2.Contains(n))
                {
                    answer[0].Add(n);
                }
            }
            foreach (int n in set2)
            {
                if (!set1.Contains(n))
                {
                    answer[1].Add(n);
                }
            }
            return answer;
        }
    }
}
