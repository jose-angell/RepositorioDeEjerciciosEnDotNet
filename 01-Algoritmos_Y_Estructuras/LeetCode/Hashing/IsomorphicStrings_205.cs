using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 205. Isomorphic Strings
 * Dado dos strings s y t, determinar si son isomorfos. 
 * Dos string son isomorfos si los caracteres en s pueden ser reemplazados para obtener t.
 * esto implica que todos las ocurrencias de un caracter deben ser reemplazadas por otro caracter mientras se preserva el orden de los caracteres.
 * imput : s = "egg", t = "add"
 * output: true
 * Solucion O(n) tiempo y O(1) espacio adicional
 * 1.Crear dos diccionarios para mapear los caracterse de s a t y de t a s.
 * 2.Recorrer ambos strings simultaneamente y llenar los diccionarios con los mapeos de caracteres.
 * 3.Recorrer nuevamente ambos strings y verificar que los mapeos en los diccionarios sean consistentes.
 *    Se evaluea que el caracter en s mapee al caracter correspondiente en t y viceversa. Si esto no se cumple retorna un false
 * 4. Si se completa el recorrido sin inconsistencias, retornar true.
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class IsomorphicStrings_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dicS = new Dictionary<char, char>();
            var dicT = new Dictionary<char, char>();
            if (s.Length != t.Length) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dicS.ContainsKey(s[i]))
                {
                    dicS.Add(s[i], t[i]);
                }
                if (!dicT.ContainsKey(t[i]))
                {
                    dicT.Add(t[i], s[i]);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dicS[s[i]] != t[i] || dicT[t[i]] != s[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
