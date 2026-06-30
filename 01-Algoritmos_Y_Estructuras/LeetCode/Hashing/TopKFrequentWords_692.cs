using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 692. Top K Frequent Words
 * Dada una matriz de cadenas words y un entero k, devuelve las k palabras más frecuentes.
 * Devuelve las palabras en orden de frecuencia de mayor a menor. 
 * Si dos palabras tienen la misma frecuencia, devuelve la palabra con el orden alfabético más bajo.
 * 
 * solucion:
 * 1. Crear un diccionario para contar la frecuencia de cada palabra.
 * 2. Ordenar las palabras primero por frecuencia (de mayor a menor) y luego por orden alfabético (de menor a mayor).
 * 3. Tomar las primeras k palabras del resultado ordenado.
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class TopKFrequentWords_692
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var frequent = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (frequent.ContainsKey(w))
                {
                    frequent[w]++;
                }
                else
                {
                    frequent[w] = 1;
                }
            }
            List<string> listaPalabras = new List<string>(frequent.Keys);

            listaPalabras.Sort((a, b) => {
                int freqA = frequent[a];
                int freqB = frequent[b];

                if (freqA != freqB)
                {
                    return freqB.CompareTo(freqA);
                }

                return a.CompareTo(b);
            });
            List<string> res = new List<string>();
            for (int i = 0; i < k; i++)
            {
                res.Add(listaPalabras[i]);
            }

            return res;
        }
        public IList<string> TopKFrequentLinq(string[] words, int k)
        {
            var frequent = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (frequent.ContainsKey(w))
                {
                    frequent[w]++;
                }
                else
                {
                    frequent[w] = 1;
                }
            }
            var res = frequent
               .OrderByDescending(par => par.Value) // Mayor frecuencia primero
               .ThenBy(par => par.Key)              // Alfabético si hay empate
               .Select(par => par.Key)              // Seleccionar solo el texto de la palabra
               .Take(k)                             // Tomar solo las primeras K palabras
               .ToList();                           // Convertir a lista

            return res;
        }
    }
}
