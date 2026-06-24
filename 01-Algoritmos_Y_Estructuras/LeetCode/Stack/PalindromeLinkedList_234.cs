using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 234. Palindrome Linked List
 * Dado el head de una lista enlazada, devuelve true si la lista es un palíndromo o false en caso contrario.
 * 
 * Solucion
 * 1. Crear una pila para almacenar los valores de los nodos de la lista enlazada.
 * 2. Recorrer la lista enlazada y agregar los valores de los nodos a la pila.
 * 3. Recorrer nuevamente la lista enlazada y comparar los valores de los nodos con los valores en la pila. Si algún valor no coincide, devolver false.
 * 4. Si todos los valores coinciden, devolver true.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class PalindromeLinkedList_234
    {
        public bool IsPalindrome(ListNode head)
        {
            var st = new Stack<int>();
            var newHead = head;
            while (head != null)
            {
                st.Push(head.val);
                head = head.next;
            }
            while (newHead != null)
            {
                if (st.Pop() != newHead.val) return false;
                newHead = newHead.next;
            }
            return true;
        }
    }
}
