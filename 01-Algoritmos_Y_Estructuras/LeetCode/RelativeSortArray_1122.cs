using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1122. Relative Sort Array
 * Dado dos arrays de numeros enteros, arr1 y arr2, ordenar los elementos de arr1 segun el orden que se encuentra en arr2, los elementos que no se encuentran en arr2 deben ser colocados al final del array ordenados de forma ascendente.
 * input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
 * output: [2,2,2,1,4,3,3,9,6,7,19]
 * 
 * solucion 
 * 1. Crear un diccionario para almacenar el orden de cada elemento en arr2, donde la clave es el numero y el valor es su posicion en arr2
 * 2. Ordenar arr1 utilizando el diccionario para determinar el orden de cada elemento, si un elemento no se encuentra en el diccionario, asignarle un valor mayor a cualquier valor en arr2 para que se coloque al final del array ordenado.
 * 3. Retornar el array ordenado.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RelativeSortArray_1122
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr2.Length; i++)
            {
                dict.Add(arr2[i], i);
            }
            int n = arr1.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (!dict.ContainsKey(arr1[j]) || !dict.ContainsKey(arr1[j + 1]))
                    {
                        dict.TryAdd(arr1[j], 1000 + arr1[j]);
                        dict.TryAdd(arr1[j + 1], 1000 + arr1[j + 1]);
                    }
                    if (dict[arr1[j]] > dict[arr1[j + 1]])
                    {
                        int aux = arr1[j + 1];
                        arr1[j + 1] = arr1[j];
                        arr1[j] = aux;
                    }
                }
            }
            return arr1;
        }
    }
}
