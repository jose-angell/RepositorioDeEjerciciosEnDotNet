using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 921. Minimum Add to Make Parentheses Valid
 * Dado un string s que consiste solo en los caracteres '(' y ')', devuelve el número mínimo de paréntesis que se deben agregar para que la cadena sea válida.
 * 
 * Solucion
 * 1. Crear una pila para almacenar los paréntesis abiertos.
 * 2. Recorrer la cadena y para cada carácter:
 *    a. Si es un paréntesis abierto '(', agregarlo a la pila.
 *    b. Si es un paréntesis cerrado ')', verificar si la pila no está vacía y el tope de la pila es un paréntesis abierto '('. Si es así, hacer pop de la pila. De lo contrario, agregar el paréntesis cerrado a la pila.
 * 3. Al final del recorrido, el tamaño de la pila será el número mínimo de paréntesis que se deben agregar para que la cadena sea válida.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class MinimumAddToMakeParenthesesValid_921
    {
        public int MinAddToMakeValid(string s)
        {
            var st = new Stack<char>();
            foreach (char c in s)
            {
                if (st.Count > 0 && c == ')' && st.Peek() == '(')
                {
                    st.Pop();
                }
                else
                {
                    st.Push(c);
                }
            }
            return st.Count;
        }
    }
}
