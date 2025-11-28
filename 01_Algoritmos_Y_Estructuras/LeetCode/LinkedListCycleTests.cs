using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class LinkedListCycleTests
    {
        /// <summary>
        /// Crear una lista enlazada y, opcionalmente, un ciclo.
        /// </summary>
        /// <param name="values">Los valores de los nodos.</param>
        /// <param name="pos">El indice (basado en 0) donde la cola debe apuntar para crear el ciclo. -1 si no hay ciclo.</param>
        /// <returns>La cabeza (head) de la lista.</returns> 
        private ListNode BuildLinkedList(int[] values, int pos)
        {
            if (values == null || values.Length == 0)
            {
                return null;
            }
            ListNode head = new ListNode(values[0]); // Crear el nodo cabeza
            ListNode current = head;
            ListNode cycleStartNode = null;
            if(pos == 0)
            {
                cycleStartNode = head; // Si el ciclo comienza en la cabeza
            }
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
                if (i == pos)
                {
                    cycleStartNode = current; // Capturar el nodo donde el ciclo debe comenzar (el 'enganche')
                }
            }
            if (pos >= 0)
            {
                current.next = cycleStartNode; // Crear el ciclo
            }
            return head;
        }
        [Fact]
        public void Cycle_shouldReturnFalse_WhenListIsEmpty()
        {
            // Arrange
            var solver = new LinkedListCycle();
            ListNode head = BuildLinkedList(new int[] { }, -1);

            // Act
            bool result = solver.Solution(head);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Cycle_ShouldReturnFalse_WhenNoCycle()
        {
            // Arrange
            var solver = new LinkedListCycle();
            ListNode head = BuildLinkedList(new int[] { 1, 2, 3, 4, 5 }, -1);

            // Act 
            bool result = solver.Solution(head);

            // Assert 
            Assert.False(result);
        }
        [Fact]
        public void Cycle_ShouldReturnTrue_WhenCyclePointsToHead()
        {
            // Arrange
            var solver = new LinkedListCycle();
            // El ciclo apunta al índice 0 (el head).
            ListNode head = BuildLinkedList(new int[] { 1, 2, 3 }, 0);

            // Act
            bool result = solver.Solution(head);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Cycle_ShouldReturnTrue_WhenCyclePointsToMiddle()
        {
            // Arrange
            var solver = new LinkedListCycle();
            ListNode head = BuildLinkedList(new int[] { 1, 2, 3, 4 }, 1);

            // Act
            bool result = solver.Solution(head);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Cycle_ShouldReturnTrue_WhenShortCycle()
        {
            // Arrange
            var solver = new LinkedListCycle();
            ListNode head = BuildLinkedList(new int[] { 1, 2 }, 0);

            // Act
            bool result = solver.Solution(head);

            // Assert
            Assert.True(result);
        }
    }
}
