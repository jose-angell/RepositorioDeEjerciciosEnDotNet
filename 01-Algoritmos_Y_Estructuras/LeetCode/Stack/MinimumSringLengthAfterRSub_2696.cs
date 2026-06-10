using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2696. Minimum String Length After Removing Substrings
 * dada una cadena s, puedes eliminar cualquier cantidad de veces la subcadena "AB" y/o "CD". Devuelve la longitud mínima de la cadena resultante.
 * 
 * solucion
 * 1. Recorrer cada caracter de la cadena:
 *    - Si la pila no esta vacia y el caracter actual es 'B' y
 *    el caracter en la cima de la pila es 'A', entonces se elimina el caracter en la cima de la pila y el caracter actual no se guarda en la pila.
 *    - Si la pila no esta vacia y el caracter actual es 'D' y el caracter en la cima de la pila es 'C', entonces se elimina el caracter en la cima de la pila y el caracter actual no se guarda en la pila.
 *    - En caso contrario, se guarda el caracter actual en la pila.
 * 2. Devolver la cantidad de caracteres que quedan en la pila.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class MinimumSringLengthAfterRSub_2696
    {
        public int MinLength(string s)
        {
            var st = new Stack<char>();
            foreach (char c in s)
            {
                if (st.Count() > 0)
                {
                    if ((st.Peek() == 'A' && c == 'B') || (st.Peek() == 'C' && c == 'D'))
                    {
                        st.Pop();
                        continue;
                    }
                }
                st.Push(c);
            }
            return st.Count();
        }
    }
}
