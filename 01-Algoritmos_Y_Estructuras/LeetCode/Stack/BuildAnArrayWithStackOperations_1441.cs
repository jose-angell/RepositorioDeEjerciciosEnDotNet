using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1441 Build an Array With Stack Operations
 * Dado un arreglo de enteros target y un entero n, regresa una lista de cadenas que representa las operaciones necesarias para construir el arreglo target utilizando una pila. Las operaciones permitidas son "Push" (agregar un elemento a la pila) y "Pop" (eliminar el elemento superior de la pila). El arreglo target se construye agregando elementos a la pila en orden ascendente desde 1 hasta n.
 * input: target = [1,3], n = 3
 * ouput: ["Push","Push","Pop","Push"]
 * solucion O(n)
 * 1. Crear un conjunto (HashSet) a partir del arreglo target para permitir búsquedas rápidas de los elementos.
 * 2. Inicializar una lista de cadenas para almacenar las operaciones resultantes.
 * 3. Recorrer los números del 1 al n:
 *      - Si el número actual no está en el conjunto, agregar "Push" a la lista de operaciones y luego "Pop" para simular agregar y eliminar ese número de la pila.
 *      - Si el número actual está en el conjunto, agregar solo "Push" a la lista de operaciones para simular agregar ese número a la pila.
 *      - Si el número actual es igual al último elemento del arreglo target, detener el recorrido ya que se ha construido el arreglo objetivo.
 * 4. Regresar la lista de operaciones resultante.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class BuildAnArrayWithStackOperations_1441
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var hash = new HashSet<int>(target);
            List<string> res = new();
            for (int i = 1; i <= n; i++)
            {
                if (!hash.Contains(i))
                {
                    res.Add("Push");
                    res.Add("Pop");
                }
                else
                {
                    res.Add("Push");
                }
                if (i == target[^1]) break;
            }
            return res;
        }
    }
}
