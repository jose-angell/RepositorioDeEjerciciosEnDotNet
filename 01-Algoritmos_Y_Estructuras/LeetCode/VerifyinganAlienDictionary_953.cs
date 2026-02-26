using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 953. Verifying an Alien Dictionary
 * Dado un array de palabras y un string order que representa el orden de las letras en un idioma alienigena, retornar true si y solo si las palabras estan ordenadas lexicograficamente segun el orden del idioma alienigena.
 * input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
 * output: true
 * solucion O(n) y espacio O(1)
 * 1. Crear un diccionario para almacenar el orden de cada letra en el idioma alienigena, donde la clave es la letra y el valor es su posicion en el orden
 * 2. Recorrer el array de palabras, comparando cada palabra con la siguiente, y para cada par de palabras, comparar cada letra de ambas palabras utilizando el diccionario
 * para determinar su orden. Si se encuentra una letra que esta en un orden diferente, retornar false. si se llega al final de una palabra sin encontrar diferencias,
 * verificar que la palabra mas corta es la que esta antes en el orden, si no es asi retornar false. si se recorren todas las palabras sin encontrar diferencias, 
 * retornar true.
 * 
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class VerifyinganAlienDictionary_953
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var alpha = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                alpha.Add(order[i], i);
            }
            for (int i = 1; i < words.Length; i++)
            {
                string a = words[i - 1];
                string b = words[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (j == b.Length) return false;
                    char achar = a[j];
                    char bchar = b[j];
                    if (alpha[achar] < alpha[bchar]) break;
                    if (alpha[achar] > alpha[bchar]) return false;
                }
            }
            return true;

        }
    }
}
