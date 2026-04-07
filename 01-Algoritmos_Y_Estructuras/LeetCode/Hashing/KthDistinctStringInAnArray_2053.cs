using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2053. Kth Distict String in an Array
 * La entrada en un array de strings, este consunto tinen valores que solo aparecen una unica vez, pero pueden ser n cantidad de unicos valores, la otra entrada en un valor 
 * entero k la posicion del valor unico que se desea retornar, pero solo tomando enn cuenta los valores unicos dentro del array original,
 * 
 * solucion O(n) y espacio O(n)
 * 1. crear un diccionario para conocer la frecuencia de cada elemetento del array, y poder identificar los valore unicos
 * 2. recorrer el array original otra vez, para identificar que valor unico esta en la posicion de k, restando 1 a k cada vez que se encuentra un elemento unico y retornando ese elemento si k es igual a 0
 * 3. si el for termina entonce se retorna un string vacio.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class KthDistinctStringInAnArray_2053
    {
        public string KthDistinct(string[] arr, int k)
        {
            var dic = new Dictionary<string, int>();
            foreach (string a in arr)
            {
                dic.TryAdd(a, 0);
                dic[a]++;
            }

            foreach (string a in arr)
            {
                if (dic[a] == 1)
                {
                    k--;
                    if (k == 0) return a;
                }
            }
            return "";
        }
    }
}
