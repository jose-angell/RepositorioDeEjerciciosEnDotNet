using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2032. Two Out of Three
 * Dado tres arreglos de enteros nums1, nums2 y nums3, devuelve un arreglo que contenga todos los enteros distintos que aparecen en al menos dos de los tres arreglos.
 * 
 * Solucion
 * 1. Crear tres conjuntos (HashSet) para almacenar los elementos distintos de cada arreglo.
 * 2. Recorrer los tres arreglos y agregar sus elementos a los conjuntos correspondientes.
 * 3. Crear una lista para almacenar el resultado.
 * 4. Recorrer los números del 1 al 100 (ya que los elementos están en el rango [1, 100]) y contar cuántos conjuntos contienen cada número.
 * 5. Si un número aparece en al menos dos conjuntos, agregarlo a la lista de resultados.
 * 6. Devolver la lista de resultados.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class TwoOutofThree_2032
    {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {

            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);
            HashSet<int> set3 = new HashSet<int>(nums3);

            List<int> res = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                if (set1.Contains(i))
                    count++;
                if (set2.Contains(i))
                    count++;
                if (set3.Contains(i))
                    count++;

                if (count >= 2)
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
