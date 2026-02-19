using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 1684. Count the Number of Consistent Strings
 * Dado un string de caracteres permitidos y un array de palabras, contar cuantas palabras del array son consistentes, es decir, que solo contienen caracteres del string de permitidos
 * Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
 * Output: 2
 * 
 * 
 * solucion: O(n^2) y espacio O(n)
 * 1. Crear un hashset con los caracteres permitidos
 * 2. Inicializar una variable para contar las palabras consistentes
 * 3. Recorrer el array de palabras y para cada palabra, recorrer sus caracteres y validar si cada caracter esta en el hashset de permitidos, si no lo esta, marcar la palabra como inconsistente y salir del ciclo
 * 4. Si la palabra es consistente, incrementar el contador
 * 5. Retornar el contador de palabras consistentes
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class CountNumberConsistentStrings_1684
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var allowSet = new HashSet<char>(allowed);
            int sum = 0;

            foreach (string w in words)
            {
                bool isAllow = true;
                foreach (char c in w)
                {
                    if (!allowSet.Contains(c))
                    {
                        isAllow = false;
                        break;
                    }
                }
                if (isAllow)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
