using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 394. Decode String
 * Dada una cadena codificada, devuelve su cadena decodificada.
 * la codificación se realiza de la siguiente manera: k[encoded_string], donde el encoded_string dentro de los corchetes se repite exactamente k veces. Nota: k es un número positivo.
 * 
 * Solucion
 * 1. Crear dos pilas: una para almacenar los segmentos de cadena y otra para almacenar los números de repetición.
 * 2. Recorrer cada carácter de la cadena de entrada:
 *    - Si el carácter es un dígito, actualizar el número de repetición actual.
 *    - Si el carácter es '[', empujar el número de repetición actual a la pila de repeticiones y empujar un nuevo StringBuilder vacío a la pila de segmentos.
 *    - Si el carácter es ']', sacar el segmento actual de la pila de segmentos y el número de repetición de la pila de repeticiones, y repetir el segmento según el número de repetición, agregándolo al segmento anterior en la pila.
 *    - Si el carácter es una letra, agregarlo al segmento actual en la parte superior de la pila de segmentos.
 * 3. Al final, devolver el contenido del StringBuilder en la parte superior de la pila de segmentos como resultado final.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class DecodeString_394
    {
        public string DecodeString(string s)
        {
            var segments = new Stack<StringBuilder>();
            var repeats = new Stack<int>();
            segments.Push(new());
            var rep = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    rep = rep * 10 + (c - '0');
                }
                else if (c == '[')
                {
                    repeats.Push(rep);
                    segments.Push(new());
                    rep = 0;
                }
                else if (c == ']')
                {
                    var segment = segments.Pop();
                    var repeat = repeats.Pop();
                    for (int i = 0; i < repeat; i++) segments.Peek().Append(segment);
                }
                else
                {
                    segments.Peek().Append(c);
                }
            }
            return segments.Pop().ToString();
        }
    }
}
