using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1832. Check if the Sentence is Pangram
 * Dado una entrada de tipo string validar si todas las letras del alfabeto aparecen almenos una vez
 * Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
 * Output: true
 * Solucion: O(n) y espacio O(n)
 * 1. Inicializar un hashSet con los elementos del string de entrada
 * 2. crear una variable que almacene todos los elementos del alfabeto
 * 3. Recorrer el alfabeto y validar si aparece en el hashset del string de entrada, si no lo hace retornar false
 * 4. Si el ciclo termina retornar true.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class CheckIfSentenceIsParagram_1832
    {
        public bool CheckIfPangram(string sentence)
        {
            HashSet<char> sens = new(sentence);
            string alpha = "qwertyuiopasdfghjklzxcvbnm";
            foreach (char a in alpha)
            {
                if (!sens.Contains(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
