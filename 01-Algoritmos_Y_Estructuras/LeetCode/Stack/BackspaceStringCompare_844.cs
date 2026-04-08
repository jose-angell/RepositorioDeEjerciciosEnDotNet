using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 844. Backspace String Compare`
 * Dado dos cadenas s y t, regresa true si son iguales cuando se procesan las teclas de retroceso representadas por el carácter '#'.
 * input: s = "ab#c", t = "ad#c"
 * output: true
 * 
 * solucion: O(n)
 * 1. Crear dos pilas para almacenar los caracteres de cada cadena.
 * 2. Recorrer cada cadena y procesar los caracteres:
 *      si el carácter es '#', eliminar el último carácter de la pila (si no está vacía).
 *      si el carácter no es '#', agregarlo a la pila.
 * 3. Comparar las pilas resultantes para determinar si son iguales.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class BackspaceStringCompare_844
    {
        public bool BackspaceCompare(string s, string t)
        {
            var stack_s = new Stack<char>();
            var stack_t = new Stack<char>();
            foreach (char i in s)
            {
                if (stack_s.Count > 0 && i == '#')
                {
                    stack_s.Pop();
                }
                else if (i != '#')
                {
                    stack_s.Push(i);
                }
            }
            foreach (char i in t)
            {
                if (stack_t.Count > 0 && i == '#')
                {
                    stack_t.Pop();
                }
                else if (i != '#')
                {
                    stack_t.Push(i);
                }
            }
            return stack_s.SequenceEqual(stack_t);
        }
    }
}
