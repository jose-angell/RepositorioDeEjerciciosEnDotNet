using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1249. Minimum Remove to Make Valid Parentheses
 * Dado un string s que contiene paréntesis y letras, elimine el número mínimo de paréntesis para que el resultado sea un string válido.
 * input: s = "lee(t(c)o)de)"
 * output: "lee(t(c)o)de"
 * 
 * Solucion
 * 1. Crear una pila para almacenar los índices de los paréntesis.
 * 2. Recorrer el string y para cada paréntesis, si es un paréntesis de apertura, agregar su índice a la pila. Si es un paréntesis de cierre, verificar si la pila no está vacía y el paréntesis en la parte superior de la pila es un paréntesis de apertura, entonces eliminar el índice de la pila. De lo contrario, agregar el índice del paréntesis de cierre a la pila.
 * 3. crear un StringBuilder para construir el resultado final.
 * 4. Recorrer la pila y eliminar los caracteres en los índices almacenados en la pila del StringBuilder.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class MinimunRemoveToMakeValidParentheses_1249
    {
        public string MinRemoveToMakeValid(string s)
        {
            var st = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == ')')
                {
                    if (st.Count > 0 && s[i] == ')' && s[st.Peek()] == '(')
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(i);
                    }
                }
            }
            var sb = new StringBuilder(s);
            while (st.Count > 0)
            {
                sb.Remove(st.Pop(), 1);
            }
            return sb.ToString();
        }
    }
}
