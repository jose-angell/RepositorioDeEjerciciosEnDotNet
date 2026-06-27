using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 946. Validate Stack Sequences
 * Dadas dos secuencias de enteros pushed y popped con distinción de elementos, devuelve true si y solo si esta podría ser la secuencia de operaciones de un stack que empuja los elementos de pushed y hace pop de los elementos de popped.
 * 
 * Solucion
 * 1. Crear una pila auxiliar para simular el proceso de push y pop.
 * 2. Inicializar un índice i para rastrear la posición en la secuencia popped.
 * 3. Recorrer cada elemento x en la secuencia pushed:
 *    - Empujar x a la pila auxiliar.
 *    - Mientras la pila auxiliar no esté vacía y el elemento en la parte superior de la pila sea igual al elemento en popped[i], hacer pop de la pila auxiliar y avanzar i.
 * 4. Al final, si la pila auxiliar está vacía, significa que todas las operaciones fueron válidas, por lo que se devuelve true; de lo contrario, se devuelve false.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    internal class ValidateStackSequences_946
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var aux = new Stack<int>();
            int i = 0;
            foreach (int x in pushed)
            {
                aux.Push(x);
                while (aux.Count > 0 && aux.Peek() == popped[i])
                {
                    aux.Pop();
                    i++;
                }
            }
            return aux.Count == 0;
        }
    }
}
