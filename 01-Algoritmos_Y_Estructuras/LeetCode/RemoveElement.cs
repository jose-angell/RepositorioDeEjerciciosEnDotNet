using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Remove Element
 * Se pide encontrar un valor k que representa un nuevo rango dentro de un array de numeros enteros, este array contiene una lista de numeros
 * que seran evaluado con uun valor en val, al final el array nums debera poder mostrar solo los valores diferentes de val al recorrer los 
 * desde 0 hasta k, 
 * Entrada: int[] nums array de numeros enteros, int val un valor entero
 * Salida: int k el valor entero
 * 
 * No se debe crear un nuevo array, se debe modificar el mismo que de entrar, y tampoco es necesario borrar los elementos con re organizarlo es 
 * suficiente
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RemoveElement
    {
        public int Solution(int[] nums, int val)
        {
            if (nums == null) return 0;
            int k = 0;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
    }
}
