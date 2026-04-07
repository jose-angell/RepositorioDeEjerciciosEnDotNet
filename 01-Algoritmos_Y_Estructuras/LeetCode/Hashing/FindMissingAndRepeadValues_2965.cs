using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2965. Find Missing and Repeated Values
 * Dado un array bidimensional grid de tamaño n x n que contiene enteros del 1 al n^2, encontrar el valor que se repite y el valor que falta. El array grid contiene exactamente un valor que se repite y exactamente un valor que falta.
 * 
 * Input: grid = [[1,2],[2,4]]
 * Output: [2,3]
 * 
 * Solucion O(n^2) tiempo y O(n^2) espacio adicional
 * 1. Crear un diccionario para contar la frecuencia de cada número del 1 al n^2 en el array grid.
 * 2. Recorrer el array grid y actualizar la frecuencia de cada número en el diccionario.
 * 3. Recorrer el diccionario para identificar el número que se repite (frecuencia > 1) y el número que falta (frecuencia == 0).
 * 4. Retornar un array con el número que se repite y el número que falta como resultado.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FindMissingAndRepeadValues_2965
    {
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            int n = grid.Length;
            var d = new Dictionary<int, int>();
            var res = new int[2];
            for (int i = 1; i <= n * n; i++)
            {
                d.TryAdd(i, 0);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    d[grid[i][j]] += 1;
                }
            }
            foreach (var i in d)
            {
                if (i.Value > 1)
                {
                    res[0] = i.Key;
                }
                if (i.Value == 0)
                {
                    res[1] = i.Key;
                }
            }
            return res;
        }
    }
}
