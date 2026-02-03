using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 290. Word Pattern
 * Dado dos strings pattern y s determinar si son s sigue el mismo patron. 
 * imput : pattern = "abba", s = "dog cat cat dog"
 * output: true
 * Solucion O(n) tiempo y O(1) espacio adicional
 * 1.Crear dos diccionarios para mapear los caracterse de s a pattern y de pattern a s.
 * 2.Crear un areglo de strings dividiendo s por espacios.
 * 3.Recorrer ambos strings simultaneamente y llenar los diccionarios con los mapeos de caracteres.
 * 4.Recorrer nuevamente ambos strings y verificar que los mapeos en los diccionarios sean consistentes.
 *    Se evaluea que el caracter en s mapee al caracter correspondiente en pattern y viceversa. Si esto no se cumple retorna un false
 * 5. Si se completa el recorrido sin inconsistencias, retornar true.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class WordPattern_290
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] sArray = s.Split(' ');
            var dicS = new Dictionary<string, char>();
            var dicP = new Dictionary<char, string>();
            if (sArray.Length != pattern.Length) return false;
            for (int i = 0; i < sArray.Length; i++)
            {
                if (!dicS.ContainsKey(sArray[i]))
                {
                    dicS.Add(sArray[i], pattern[i]);
                }
                if (!dicP.ContainsKey(pattern[i]))
                {
                    dicP.Add(pattern[i], sArray[i]);
                }
            }
            for (int i = 0; i < sArray.Length; i++)
            {
                if (dicS[sArray[i]] != pattern[i] || dicP[pattern[i]] != sArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
