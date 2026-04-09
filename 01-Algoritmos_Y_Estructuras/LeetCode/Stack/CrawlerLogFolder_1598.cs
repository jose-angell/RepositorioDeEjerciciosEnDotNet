using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1598. Crawler Log Folder
 * Dado un arreglo de cadenas logs, cada una representando una operación de registro de un rastreador, regresa el número mínimo de operaciones necesarias para regresar a la carpeta raíz después de ejecutar todas las operaciones.
 * input: logs = ["d1/","d2/","../","d21/","./"]
 * output: 2
 * solucion: O(n)
 * 1. Crear una pila para simular la navegacion entre carpetas.
 * 2. Recorrer cada operación en el arreglo logs:
 *      - Si la operación es "../", eliminar el último elemento de la pila (si no está vacía) para simular regresar a la carpeta anterior.
 *      - Si la operación es "./", no hacer nada ya que representa permanecer en la carpeta actual.
 *      - Si la operación es un nombre de carpeta (termina con "/"), agregarlo a la pila para simular entrar a esa carpeta.
 * 3. Al finalizar el recorrido, regresar el tamaño de la pila
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class CrawlerLogFolder_1598
    {
        public int MinOperations(string[] logs)
        {
            var stack = new Stack<string>();
            foreach (var log in logs)
            {
                if (stack.Count > 0 && log == "../")
                {
                    stack.Pop();
                    continue;
                }
                if (log == "./" || log == "../") continue;
                stack.Push(log);
            }
            return stack.Count;
        }
    }
}
