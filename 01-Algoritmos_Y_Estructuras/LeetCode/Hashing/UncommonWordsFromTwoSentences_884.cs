using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 884. Uncommon Words from Two Sentences
 * Dado dos sentencias s1 y s2, retornar un array de todas las palabras que son poco comunes en ambas sentencias. Una palabra es poco comun si aparece exactamente una vez
 * en total en ambas sentencias. El array de retorno puede ser retornado en cualquier orden.
 * 
 * Input: s1 = "this apple is sweet", s2 = "this apple is sour"
 * Output: ["sweet","sour"]
 * 
 * Solucion O(n) y espacio O(n)
 * 1. Crear un diccionario para contar la frecuencia de cada palabra en ambas sentencias
 * 2. Crear una variable para almacenar las palabras poco comunes encontradas, inicializada en una lista vacia
 * 3. convertir cada sentencia en un array de palabras utilizando el metodo Split y recorrer cada palabra en ambas sentencias, actualizando la frecuencia de cada palabra 
 * en el diccionario
 * 4.Recorrer el diccionario y para cada palabra, verificar si su frecuencia es exactamente 1, y si es asi, agregar la palabra a la lista de palabras poco comunes encontradas
 * 5. Retornar la lista de palabras poco comunes encontradas convertida a un array
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class UncommonWordsFromTwoSentences_884
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            var dict = new Dictionary<string, int>();
            List<string> res = [];
            foreach (string w in s1.Split(" "))
            {
                dict.TryAdd(w, 0);
                dict[w] += 1;
            }
            foreach (string w in s2.Split(" "))
            {
                dict.TryAdd(w, 0);
                dict[w] += 1;
            }
            foreach (var d in dict)
            {
                if (d.Value == 1)
                {
                    res.Add(d.Key);
                }
            }
            return res.ToArray();
        }
    }
}
