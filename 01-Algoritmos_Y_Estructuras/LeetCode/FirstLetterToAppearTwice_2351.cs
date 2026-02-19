using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2351. First Letter to Appear Twice
 * Dado un string de letras minusculas encontrar la primera letra que aparece dos veces
 * 
 * Input: s = "abccbaacz"
 * Output: "c"
 * 
 * Solucion: O(n) y espacio O(n)
 * 1. Inicializar un hashset para guardar las letras que ya han aparecido
 * 2. Recorrer el string de entrada y verificar si la letra ya esta en el hashset, si esta, retornar esa letra
 * 
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FirstLetterToAppearTwice_2351
    {
        public char RepeatedCharacter(string s)
        {
            HashSet<char> twiceSet = new HashSet<char>();
            foreach (char letter in s)
            {
                if (twiceSet.Contains(letter))
                {
                    return letter;
                }
                twiceSet.Add(letter);
            }
            return new char();
        }
    }
}
