using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1346. Check If N and Its Double Exist
 * Dado un array de enteros arr, devuelve true si existe dos índices i y j tal que :
 * i != j
 * 0 <= i, j < arr.length
 * arr[i] == 2 * arr[j]
 * 
 * Solucion
 * 1. Crear un HashSet para almacenar los elementos del array.
 * 2. Recorrer el array y para cada elemento, verificar si el HashSet contiene el doble del elemento o la mitad del elemento (si el elemento es par). Si es así, devolver true. De lo contrario, agregar el elemento al HashSet.
 * 3. Si se recorre todo el array sin encontrar una coincidencia, devolver false.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class CheckifNandItsDoubleExist_1346
    {
        public bool CheckIfExist(int[] arr)
        {
            var hs = new HashSet<int>();
            foreach (int i in arr)
            {
                if (hs.Contains(i * 2) || (i % 2 == 0 && hs.Contains(i / 2)))
                {
                    return true;
                }
                else
                {
                    hs.Add(i);
                }
            }
            return false;
        }
    }
}
