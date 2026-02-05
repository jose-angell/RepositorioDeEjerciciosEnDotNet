using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 350. Intersection of Two Arrays II
 * Dado dos arrays de enteros nums1 y nums2, retornar un array que represente su interseccion. Cada elemento en el resultado
 * debe aparecer tantas veces como se repita en ambos arrays y puede ser retornado en cualquier orden.
 * input: nums1 = [1,2,2,1], nums2 = [2,2]
 * ouput: [2,2]
 * solucion O(n) tiempo y O(n) espacio adicional
 * 1. Definir un diccionario para contar las ocurrencias de cada numero en nums1.
 * 2. Definir una lista para almacenar la interseccion.
 * 3. llenar el diccionario con las ocurrencias de cada numero en nums1.
 * 4. Recorrer nums2 y verificar si el numero existe en el diccionario y su conteo es mayor que cero.
 *      si exite, agregar el numero a  la lista de interseccion y decrementar su conteo en el diccionario.
 * 5. Convertir la lista de interseccion a un array y retornarlo.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class IntersectionOtTwoArraysII_350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var counterNums1 = new Dictionary<int, int>();
            var counterNums2 = new Dictionary<int, int>();
            var minRepeat = new Dictionary<int, int>();
            List<int> interSect = new List<int>();
            foreach (int i in nums1)
            {
                if (counterNums1.ContainsKey(i))
                {
                    counterNums1[i] += 1;
                }
                else
                {
                    counterNums1.Add(i, 1);
                }
            }
            foreach (int i in nums2)
            {
                if (counterNums2.ContainsKey(i))
                {
                    counterNums2[i] += 1;
                }
                else
                {
                    counterNums2.Add(i, 1);
                }
            }

            foreach (var i in counterNums1)
            {
                if (counterNums2.ContainsKey(i.Key) && !minRepeat.ContainsKey(i.Key))
                {
                    if (counterNums2[i.Key] < i.Value)
                    {
                        minRepeat.Add(i.Key, counterNums2[i.Key]);
                    }
                    else
                    {
                        minRepeat.Add(i.Key, i.Value);
                    }
                }
            }
            foreach (var i in minRepeat)
            {
                for (int j = 0; j < i.Value; j++)
                {
                    interSect.Add(i.Key);
                }
            }

            return interSect.ToArray();
        }
        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            List<int> nums2temp = new List<int>(nums2); // create temp of nums2 to remove the match element (to avoid duplicate).

            foreach (int num in nums1)
            {
                if (nums2temp.Contains(num))
                {
                    list.Add(num);
                    nums2temp.Remove(num);
                }
            }

            return list.ToArray();
        }
        public int[] Intersect3(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in nums1)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            foreach (int num in nums2)
            {
                if (map.ContainsKey(num) && map[num] > 0)
                {
                    result.Add(num);
                    map[num]--;
                }
            }

            return result.ToArray();
        }
    }
}
