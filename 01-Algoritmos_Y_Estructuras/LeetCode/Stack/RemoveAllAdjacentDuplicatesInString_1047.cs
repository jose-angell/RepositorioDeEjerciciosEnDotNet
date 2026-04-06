using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1047 Remove All Adjacent Duplicates In String
 * Dado una cadena s, eliminar todas las apariciones de caracteres adyacentes duplicados en la cadena hasta que no queden más.
 * Input: s = "abbaca"
 * Output: "ca"
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 1. Crear una pila para almacenar los caracteres de la cadena.
 * 2. Recorrer cada caracter c en la cadena s:
 *    a. Si la pila no está vacía y el caracter en la parte superior de la pila es igual a c, entonces se ha encontrado un par de caracteres adyacentes duplicados. En este caso, se elimina el caracter de la parte superior de la pila (stack.Pop()).
 *    b. Si no se ha encontrado un par de caracteres adyacentes duplicados, se agrega el caracter c a la pila (stack.Push(c)).
 * 3. Después de recorrer toda la cadena, los caracteres restantes en la pila representan la cadena resultante sin caracteres adyacentes duplicados.
 * 4. Para construir la cadena resultante, se puede utilizar un StringBuilder para concatenar los caracteres restantes en la pila en orden inverso (ya que los caracteres se agregaron a la pila en orden).
 * 5. Finalmente, se retorna la cadena resultante construida a partir del StringBuilder.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class RemoveAllAdjacentDuplicatesInString_1047
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                    stack.Pop();
                else
                    stack.Push(c);
            }

            var res = new StringBuilder(stack.Count);

            foreach (var c in stack.Reverse())
            {
                res.Append(c);
            }

            return res.ToString();
        }
        public string RemoveDuplicates2(string s)
        {
            var stack = new Stack<char>();
            foreach (char i in s)
            {
                if (stack.Count > 0 && stack.Peek() == i)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(i);
                }
            }
            return new string(stack.Reverse().ToArray());
        }
        public string RemoveDuplicates3(string s)
        {
            char[] charValues = s.ToCharArray();
            int index = 0;
            foreach(char c in charValues)
            {
                if(index > 0 && charValues[index - 1] == c)
                {
                    index--;
                }
                else
                {
                    charValues[index] = c;
                    index++;
                }
            }
            return new string(charValues, 0, index);    
        }
    }
}
