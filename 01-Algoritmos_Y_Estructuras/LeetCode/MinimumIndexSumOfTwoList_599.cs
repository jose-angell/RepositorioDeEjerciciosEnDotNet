using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 599. Minimum Index Sum of Two Lists
 * Dado dos arrays de strings list1 y list2, los string en comun y  que tenga la menor suma de indices. Si hay una respuesta, retornar todas las respuestas.
 * Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
 * Output: ["Shogun"]
 * 
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 
 * 1. Inicializar un diccionario para almacenar los indices de los elementos en list1.
 * 2. Inicializar una lista para almacenar la respuesta.
 * 3. Inicalizar un valor minimo "min" en un valor alto (por ejemplo, 2000).
 * 4. Recorrer list1 y llenar el diccionario con los elementos y sus indices.
 * 5. Recorrer la list2 y verificar si el elemento existe en el diccionario.
 *      si existe se hace la suma de indices 
 *      Si la suma es menor que min entonces se actualiza min y se reinicia la lista de respuesta con el elemento actual.
 *      Si la suma es igual a min solo se agrega el elemento a la lista existente.
 * 6. Se convierte la lista a array y se retorna.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MinimumIndexSumOfTwoList_599
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dic = new Dictionary<string, int>();
            List<string> result = new List<string>();
            int min = 2000;
            for (var i = 0; i < list1.Length; i++)
            {
                dic.Add(list1[i], i);
            }
            for (var i = 0; i < list2.Length; i++)
            {
                if (dic.ContainsKey(list2[i]))
                {
                    int sum = dic[list2[i]] + i;
                    if (sum < min)
                    {
                        min = sum;
                        result = new List<string>() { list2[i] };
                    }
                    else if (sum == min)
                    {
                        result.Add(list2[i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
