using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 500. Keyboard Row
 * Dado un array de strings words, retornar un array de strings que contenga solo las palabras que se pueden escribir usando letras de una sola fila del teclado americano.
 * Input: words = ["Hello","Alaska","Dad","Peace"]
 * Output: ["Alaska","Dad"]
 * Soulicion O(n^2) tiempo y O(n) espacio adicional
 * 1. Definir tres conjuntos de caracteres para representar las tres filas del teclado americano.
 * 2. Inicializar una lista para almacenar las palabras que cumplen la condición.
 * 3. Recorrer cada palabra en el array de entrada y verificar si todas sus letras pertenecen a una sola fila del teclado.
 *    Para esto, se puede usar tres banderas booleanas para indicar si la palabra pertenece a cada fila.
 * 4. Si al final de revisar la palabra, alguna de las banderas es verdadera, agregar la palabra a la lista de resultados.
 * 5. Retornar la lista de resultados convertida a un array.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class KeyboardRow_500
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> rowFirst = new("qwertyuiopQWERTYUIOP");
            HashSet<char> rowSecond = new("asdfghjklASDFGHJKL");
            HashSet<char> rowThird = new("zxcvbnmZXCVBNM");
            var result = new List<string>();
            bool inFirst = true; bool inSecond = true; bool inThird = true;
            foreach (string w in words)
            {
                foreach (var i in w.ToCharArray())
                {
                    if (!rowFirst.Contains(i))
                    {
                        inFirst = false;
                    }
                    if (!rowSecond.Contains(i))
                    {
                        inSecond = false;
                    }
                    if (!rowThird.Contains(i))
                    {
                        inThird = false;
                    }
                }
                if (inFirst || inSecond || inThird)
                {
                    result.Add(w);
                }
                inFirst = true;
                inSecond = true;
                inThird = true;
            }
            return result.ToArray();
        }
    }
}
