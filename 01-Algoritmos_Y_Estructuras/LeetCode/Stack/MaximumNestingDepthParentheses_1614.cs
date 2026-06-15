using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1614. Maximum Nesting Depth of the Parentheses
 * Dado una cadena s que consiste en paréntesis redondos '(' y ')', encuentra la profundidad máxima de anidamiento de los paréntesis redondos.
 * Solucion
 * 1. Inicializamos dos variables, count y max, para llevar un seguimiento de la profundidad actual y la profundidad máxima respectivamente.
 * 2. Iteramos a través de cada carácter en la cadena s:
 * 3. Si el carácter es '(', incrementamos count en 1, lo que indica que hemos entrado en un nuevo nivel de anidamiento.
 * 4. Si el carácter es ')', decrementamos count en 1, lo que indica que hemos salido de un nivel de anidamiento.
 * 5. Después de cada incremento o decremento de count, verificamos si count es mayor que max. Si es así, actualizamos max con el nuevo valor de count.
 * 6. Al final de la iteración, max contendrá la profundidad máxima de anidamiento de los paréntesis redondos en la cadena s, que es lo que devolvemos como resultado.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class MaximumNestingDepthParentheses_1614
    {
        public int MaxDepth(string s)
        {
            int count = 0;
            int max = 0;
            foreach (char c in s)
            {
                if (c == '(') count++;
                if (c == ')') count--;
                if (count > max) max = count;
            }
            return max;
        }
        public int MaxDepthStack(string s)
        {
            int maxdepth = 0;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push('(');
                }
                else if (s[i] == ')')
                {
                    maxdepth = Math.Max(maxdepth, stack.Count);
                    stack.Pop();
                }
            }

            return maxdepth;

        }
    }
}
