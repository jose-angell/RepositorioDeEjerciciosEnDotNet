using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  1021 . Remove Outermost Parentheses
 *  Una cadena S de paréntesis válidos se llama primitiva si no se puede dividir en dos cadenas no vacías A y B, con S = A + B. Dada una cadena S de paréntesis válidos, considera todas las formas de dividir S en una concatenación de cadenas primitivas. Elimina los paréntesis exteriores de cada parte primitiva, y concatena el resultado.
 *  input: "(()())(())"
 *  output: "()()()"
 *  
 *  
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class RemoveOutermostParentheses_1021
    {
        public string RemoveOuterParentheses(string s)
        {
            int open = 0;
            StringBuilder result = new StringBuilder();
            foreach (char c in s) {
                if (c == '(')
                {
                    if (open > 0)
                    {
                        result.Append(c);
                    }
                    open++;
                }
                else if (c == ')')
                {
                    open--;
                    if (open > 0)
                    {
                        result.Append(c);
                    }
                }
            }
            return result.ToString();
        }
    
    public string RemoveOuterParenthesesWithStack(string s)
        {
            StringBuilder resultado = new StringBuilder();
            Stack<char> pila = new Stack<char>();

            foreach (char caracter in s)
            {
                if (caracter == '(')
                {
                    // Si la pila NO está vacía, significa que este '(' es interno.
                    // Por lo tanto, lo agregamos al resultado.
                    if (pila.Count > 0)
                    {
                        resultado.Append(caracter);
                    }
                    // Guardamos el paréntesis en la pila
                    pila.Push(caracter);
                }
                else if (caracter == ')')
                {
                    // Sacamos el '(' correspondiente de la pila
                    pila.Pop();

                    // Si después de sacarlo la pila NO quedó vacía, 
                    // significa que este ')' es interno y lo guardamos.
                    if (pila.Count > 0)
                    {
                        resultado.Append(caracter);
                    }
                }
            }

            return resultado.ToString();
        }
    }
}