using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1207. Unique Number of Occurrences
 * Dado un array de enteros arr, retornar true si el numero de ocurrencias de cada valor es unico o false en caso contrario.
 * input: arr = [1,2,2,1,1,3]
 * output: true
 * Explicacion: La ocurrencia de los valores son : 1 -> 3 veces, 2 -> 2 veces, 3 -> 1 vez. Todas las ocurrencias son unicas.
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 1.Crear un diccionario para contar las ocurrencias de cada numero en arr.
 * 2.Crear un HashSet para almacenar las ocurrencias unicas.
 * 3.Recorrer el array y llenar el diccionario con las ocurrencias de cada numero.
 * 4.Recorrer el diccionario y verificar si alguna ocurrencia ya existe en el HashSet.
 *    Si existe, retornar false. Si no existe, agregar la ocurrencia al HashSet.
 * 5.Si se completa el recorrido sin encontrar ocurrencias duplicadas, retornar true.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class UniqueNumberOccurrences_1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var counter = new Dictionary<int, int>();
            var unique = new HashSet<int>();
            foreach (int i in arr)
            {
                if (counter.ContainsKey(i))
                {
                    counter[i] += 1;
                }
                else
                {
                    counter.Add(i, 1);
                }
            }
            foreach (var i in counter)
            {
                if (unique.Contains(i.Value))
                {
                    return false;
                }
                else
                {
                    unique.Add(i.Value);
                }
            }
            return true;
        }
    }
}
