using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 141 Linked List Cycle
 * Teniendo como entrada una lista enlazada, determinar si la lista contiene un ciclo.
 * Input: ListNode head 
 * Output: true/false
 * Solucion: O(n) tiempo y O(1) espacio
 * - Usar dos punteros, uno lento y otro rapido, ambos inician en la cabeza de la lista
 * - Inicializar un bucle que continue mientras el puntero rapido y el siguiente del puntero rapido no sean nulos
 * - En el nodo lento muevo solo un paso el head, en el nodo rapido lo muevo dos pasos
 * - comparo si slow y fast son iguales entonces la linked list tiene ciclo y termino el bucle regresando un true
 * - si la lista termina de recorrerce sin encotrar un ciclo regreso un false
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class LinkedListCycle
    {
        public bool Solution(ListNode head)
        {
            if(head == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
