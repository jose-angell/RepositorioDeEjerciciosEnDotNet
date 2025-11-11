using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 26. Remove Duplicates from Sorted Array
 * Dada una lista de numeros enteros ordenados eliminar los valores duplicados en la misma lista de entrada
 * la salida esperada debe ser un valor entero que indique el tamano de la lista sin duplicados.
 * Input: int[] nums lista de enteros ordenada
 * Output: int numero entero que representa el numero de elementos unicos dentro de la lista
 * 
 * Complegindad de O(1) sin usar espacio extra
 * 
 * Solucion
 * 1. Iniciar k en 1 ya que el primer elemento siempre esta ordenado y es unico al ser solo uno
 * 2. Declarar un ciclo for i que comience en 1 y recorra el array hasta el final,
 * 3. validar si el elemento actual diferente al anterior entonces el actual no esta duplicado y se suma uno a k
 *    y se guarda la en la posicion k el valor en la posicion i
 * 4. al terminar el ciclo se retorna k.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RemoveDuplicates
    {
        public int Solution(int[] nums)
        {
            if(nums.Length == 0) return 0;
            int k = 1;
            for(int i =1; i< nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }
    }
}
