using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2068. Check Whether Two Strings Are Almost Equivalent
 *  Dado dos strings de letras minusculas, verificar si son casi equivalentes, es decir, si la diferencia entre la cantidad de apariciones de cada letra en ambos strings es menor o igual a 3.
 *  Input: word1 = "aaaa", word2 = "bccb"
 *  Output: false
 *  
 *  Solucion: O(n) y espacio O(n)
 *  1. Inicializar un diccionario para contar las apariciones de cada letra en ambos strings
 *  2. Recorrer ambos strings al mismo tiempo y actualizar el diccionario con las apariciones de cada letra
 *  3. Recorrer el diccionario y verificar si la diferencia entre las apariciones de cada letra es mayor a 3, si es asi, retornar false
 *  4. Si se recorre todo el diccionario sin encontrar una diferencia mayor a 3, retornar true
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class CheckWhetherTwoStringsAreAlmosEqui_2068
    {
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i <= word1.Length - 1; i++)
            {
                dict.TryAdd(word1[i], 0);
                dict.TryAdd(word2[i], 0);
                dict[word1[i]]++;
                dict[word2[i]]--;
            }
            foreach (var w in dict)
            {
                if (w.Value < -3 || w.Value > 3) return false;
            }
            return true;
        }
    }
}
