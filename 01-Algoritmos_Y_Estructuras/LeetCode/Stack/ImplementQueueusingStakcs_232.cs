using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 232. Implement Queue using Stacks
 * Implementar una cola utilizando dos pilas. La cola debe admitir las operaciones push, pop, peek y empty.
 * input: ["MyQueue", "push", "push", "peek", "pop", "empty"]  [[], [1], [2], [], [], []]
 * Output [null, null, null, 1, 1, false]
 * 
 * Solucion O(n) para push y O(1) para pop, peek y empty
 * 1. Crear dos pilas, stack1 y stack2, para almacenar los elementos de la cola.
 * 2. Para la operación push(x):
 *      - Mover todos los elementos de stack1 a stack2 para invertir el orden.
 *      - Agregar el nuevo elemento x a stack2.
 *      - Mover nuevamente todos los elementos de stack2 a stack1 para restaurar el orden original.
 * 3. Para la operación pop():
 *      - Retornar el elemento en la parte superior de stack1, que es el frente de la cola.
 * 4. Para la operación peek():
 *      - Retornar el elemento en la parte superior de stack1 sin eliminarlo, que es el frente de la cola.
 * 5. Para la operación empty():
 *      - Retornar true si stack1 está vacío, lo que indica que la cola está vacía; de lo contrario, retornar false.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class ImplementQueueusingStakcs_232
    {
        public class MyQueue
        {
            private Stack<int> stack1;
            private Stack<int> stack2;
            public MyQueue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            public void Push(int x)
            {
                //primero se reordena la informacion para que el ultimo elemento agregado quede al final
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack2.Push(x); //se agrega el nuevo elemento
                                // se reordena la pila para que el primer elemente quede al final
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }

            public int Pop()
            {
                return stack1.Pop();
            }

            public int Peek()
            {
                return stack1.Peek();
            }

            public bool Empty()
            {
                return stack1.Count == 0;
            }
        }

    }
}
