using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 283 Move Zeroes
 * Dado un array de numeros enteros, mover todos los ceros al final del array manteniendo el orden relativo 
 * de los elementos no ceros.
 * Input: [0,1,0,3,12] 
 * Output: [1,3,12,0,0] - in-place
 * 
 * Solucion: O(n) tiempo y O(1) espacio
 * - Usar dos punteros, uno para rastrear la posicion de insercion de los elementos no ceros
 * - Recorrer el array con un bucle
 * - Al inicar el bucle, ambos punteros estan en la posiccion 0
 * - Si el elemento actual es cero, uno de los punteros se queda en su lugar y el segundo puntero avanza hasta el siguiente elemento que no es cero
 * - Cuando se encuentra un elemento que no es cero, se intercambian los elementos en las posiciones de los dos punteros
 * - Ambos punteros avanzan una posicion
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MoveZeroes
    {
        public void Solution(int[] nums)
        {
            int insertPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int aux = nums[i];
                    nums[i] = nums[insertPos];
                    nums[insertPos] = aux;
                    insertPos += 1;
                }
            }
        }
    }
}
