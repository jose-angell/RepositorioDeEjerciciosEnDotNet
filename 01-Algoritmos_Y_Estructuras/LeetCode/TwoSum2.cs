using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 167 Two sum II - Imput Array is Sorted
 * Teniendo como entrada un array de enteros ordenados de forma ascendents, devuelve los indices (1-based) de los dos numeros que suman el target dado.
 * tomando en cuenta que cada entrada tiene exactamente una solucion y no se puede user el mismo elemento dos veces.
 * Input: numbers = [2,7,11,15], target = 9
 * Output: [1,2]    
 * Soucion de fuerza bruta: O(n^2)
 *  - Realizar un doble bucle para comprobar todas las combinaciones posibles. y retornar los indices cuando se encuentre la suma.
 *  
 * Solucion Optima: O(n)
 * - Utilizar dos punteros, uno al inicio y otro al final del array.
 * - crear un bucle while hasta que los punteros se crucen.
 * - Calcular la suma de los elementos en los punteros.
 * - Si la suma es igual al target, retornar los indices ajustados a 1-based.
 * - Si la suma es menor al target, mover el puntero izquierdo hacia la derecha para aumentar la suma.
 * - Si la suma es mayor al target, mover el puntero derecho hacia la izquierda para disminuir la suma.
 * - Continuar el proceso hasta encontrar la solucion.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class TwoSum2
    {
        public int[] Solution(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while(left < right)
            {
                if ((numbers[left] + numbers[right]) == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if((numbers[left] + numbers[right]) < target)
                {
                     left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
