using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 344 Reverse String
 * Dado una arreglo  de caracteres, invertir el arreglo in-place.
 * Importante: No se debe asignar otro arreglo, debe modificar el arreglo dado.
 * Imput: ['h','e','l','l','o']
 * Output: ['o','l','l','e','h']
 * 
 * Solucion: O(n) tiempo y O(1) espacio
 * - usar dos punteros, uno al inicio y otro al final del arreglo
 * - Inicializar un bucle que continue hasta que los punteros se crucen
 * - Intercambiar los caracteres en la posicion de los punteros
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ReverseString
    {
        public void Solution(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                char aux = s[start];
                s[start] = s[end];
                s[end] = aux;

                start += 1;
                end -= 1;
            }
        }
    }
}
