using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 150. Evaluate Reverse Polish Notation
 * Dado un array de strings que representan una expresión en notación polaca inversa, evalúa la expresión y devuelve el resultado.
 * Solución
 * 1. Utilizamos una pila para almacenar los operandos.
 * 2. Iteramos a través de cada token en el array:
 *    - Si el token es un operador (+, -, *, /), sacamos los dos operandos de la pila, realizamos la operación y volvemos a poner el resultado en la pila.
 *    - Si el token es un número, lo convertimos a entero y lo agregamos a la pila.
 * 3. Al final, el único elemento restante en la pila será el resultado de la expresión.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class EvalateReversePolishNotation_150
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    switch (token)
                    {
                        case "+": stack.Push(left + right); break;
                        case "-": stack.Push(left - right); break;
                        case "*": stack.Push(left * right); break;
                        case "/": stack.Push(left / right); break;
                    }
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }
            return stack.Pop();
        }
    }
}
