using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 402. Remove K Digits
 * Dada una cadena numérica no vacía que representa un número no negativo, y un entero k, elimina k dígitos del número para que el nuevo número sea el más pequeño posible.
 * 
 * solucion:
 * 1. Crear una pila para almacenar los dígitos del número.
 * 2. Recorrer cada dígito en la cadena:
 *   - Si el dígito actual es menor que el dígito en la cima de la pila y aún tenemos dígitos para eliminar (k > 0), hacer pop del dígito de la pila y decrementar k.
 *   - Empujar el dígito actual a la pila.
 * 3. Después de recorrer todos los dígitos, si aún tenemos dígitos para eliminar (k > 0), hacer pop de la pila k veces.
 * 4. Construir el número resultante a partir de los dígitos en la pila.
 * 5. Eliminar los ceros a la izquierda del número resultante.
 * 6. Si el número resultante está vacío después de eliminar los ceros a la izquierda, devolver "0". De lo contrario, devolver el número resultante.
 * 
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class RemoveKDigits_402
    {
        public string RemoveKdigits(string num, int k)
        {
            if (num.Length == k) return "0";
            Stack<char> stack = new Stack<char>();

            foreach (char digit in num)
            {
                while (k > 0 && stack.Count > 0 && stack.Peek() > digit)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(digit);
            }

            while (k > 0 && stack.Count > 0)
            {
                stack.Pop();
                k--;
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);

            int startIndex = 0;
            while (startIndex < charArray.Length && charArray[startIndex] == '0')
            {
                startIndex++;
            }

            if (startIndex == charArray.Length) return "0";

            return new string(charArray, startIndex, charArray.Length - startIndex);
        }
    }
}
