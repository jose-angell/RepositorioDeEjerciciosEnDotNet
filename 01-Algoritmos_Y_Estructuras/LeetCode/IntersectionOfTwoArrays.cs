using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 349. Intersection of Two Arrays
 * Dado dos arrays de enteros nums1 y nums2, retornar un array que represente su interseccion, un array con los 
 * elementos que estan presententes en ambos arrays. Cada elemento en el resultado debe ser unico.
 * Input: nums1 = [1,2,2,1], nums2 = [2,2]
 * Output: [2]
 * Solucion O(n) y O(n) espacio adicional
 * 1. Inicializar un HashSet para almacenar los elementos unicos del primer array.
 * 2. Inicializar un HashSet para almacenar el resultado.
 * 3. Recorrer el segundo array y validar si existe en el hashSet creado con el primer array
 * 4. Si existe la interseccion se agrega al resultado
 * 5. el hashSet con el resultado convertirlo a array y retornarlo.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>(nums1);
            var intersection = new HashSet<int>();
            foreach(var num in nums2)
            {
                if (set.Contains(num))
                {
                    intersection.Add(num);
                }
            }
            return intersection.ToArray();
        }
    }
}
