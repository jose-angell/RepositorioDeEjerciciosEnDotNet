using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 387. First Unique Character in a String
 * Dado un string 's', encontrar el primer caracter que no se repite y retornar su indice. Si no existe tal 
 * caracter unico, retornar -1.
 * Input: n = "leetcode"
 * Output: 0
 * Solucion O(n) y O(1) espacio adicional
 * 1. Inicializar un diccionario 'counter' para contar la frecuencia de cada caracter en el string 's'.
 * 2. Recorrer cada caracter en el string.
 * 3. Si el caracter ya existe en el diccionario, incrementar su contador en 1. Si no, agregarlo al diccionario con
 * un contador de 1.
 * 4. Recorrer el string nuevamente para encontrar el primer caracter con un contador de 1 en el diccionario.
 * 5.Retornar el indice de este caracter. Si no se encuentra ningun caracter unico, retornar -1.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FirstUniqueCharacterinString_387
    {
        public int FirstUniqChar(string s)
        {
            var counter = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (counter.ContainsKey(c))
                {
                    counter[c] += 1;
                }
                else
                {
                    counter[c] = 1;
                }
            }
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (counter[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
