using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1544 . Make The String Great
 *  Dada una cadena s de letras mayúsculas y minúsculas, una cadena es buena si no hay dos letras adyacentes que sean la misma letra pero de 
 *  diferente caso. Por ejemplo, "abBAcC" no es buena porque 'b' y 'B' son adyacentes y son la misma letra pero de diferente caso. Sin embargo,
 *  "abAB" es buena porque 'a' y 'A' no son adyacentes, aunque sean la misma letra. Dada una cadena s, hazla buena eliminando el número mínimo de
 *  letras posibles. Devuelve la cadena resultante. Es importante destacar que la respuesta es única.
 *  En codigo ASCII restar una letra mayuscula y su equivalente en minuscula da como resultado 32, siempre.
 *  
 *  Solucion
 *  1. Crear una pila para almacenar los caracteres de la cadena.
 *  2. Recorrer cada caracter de la cadena:
 *    - Si la pila no esta vacia y el caracter actual es igual al caracter en la cima de la pila pero la deferencia entre ellos es 32, 
 *    entonces se eliminan el caracter en la cima de la pila y el caracter actual no se guarda en la pila.
 *    -  En caso contrario, se guarda el caracter actual en la pila.
 *  4. Crear un StringBuilder para construir la cadena resultante.
 *  5. Mientras la pila no este vacia, se saca el caracter en la cima de la pila y se inserta al inicio del StringBuilder.
 *  6. Devolver la cadena resultante.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class MakeTheStringGreat_1544
    {
        public string MakeGood(string s)
        {
            var st = new Stack<char>();
            foreach (char c in s)
            {
                if (st.Count > 0 && Math.Abs(c - st.Peek()) == 32)
                {
                    st.Pop();
                }
                else
                {
                    st.Push(c);
                }
            }
            var res = new StringBuilder();
            while (st.Count > 0)
            {
                res.Insert(0, st.Pop());
            }
            return res.ToString();
        }
    }
}
