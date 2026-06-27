using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 739. Daily Temperatures
 * Dada una lista de temperaturas diarias T, devuelve una lista de enteros que indique cuántos días tendrás que esperar hasta que la temperatura sea más alta. Si no hay un día futuro para el cual esto sea posible, pon 0 en ese lugar.
 * 
 * Solución
 * 1. Crear un arreglo result del mismo tamaño que T, inicializado con ceros.
 * 2. Crear una pila para almacenar los índices de los días.
 * 3. Recorrer cada día actual en T:
 *    - Mientras la pila no esté vacía y la temperatura del día actual sea mayor que la temperatura del día en la cima de la pila:
 *      - Hacer pop del índice del día anterior de la pila.
 *      - Calcular la diferencia de días y almacenarla en result[prevDay].
 *    - Empujar el índice del día actual a la pila.
 * 4. Al final, devolver el arreglo result.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class DailyTemperatures_739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int currentDay = 0; currentDay < n; currentDay++)
            {
                // Mientras la temperatura actual sea mayor que la del día en la cima de la pila
                while (stack.Count > 0 && temperatures[currentDay] > temperatures[stack.Peek()])
                {
                    int prevDay = stack.Pop();
                    result[prevDay] = currentDay - prevDay;
                }
                stack.Push(currentDay);
            }

            // No hace falta rellenar ceros porque el arreglo ya viene inicializado con 0
            return result;
        }
    }
}
