using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 409. Longest Palindrome
 * Dado un string s que consiste en letras mayusculas y minusculas, retornar la longitud del palindromo mas largo que se puede construir con esas letras.
 * Input: s = "abccccdd"
 * Output: 7
 * Soulicion O(n) tiempo y O(n) espacio adicional
 * 1. Definir un diccionario para contar las ocurrencias de cada letra en el string.
 * 2. Inicializar un contador en cero y una bandera para verificar si hay letras con ocurrencias impares.
 * 3. Recorrer cada letra en el string y actualizar su conteo en el diccionario.
 * 4. Recorrer el diccionario y para cada letra:
 *    Si su conteo es par, agregarlo al contador.
 *    Si es impar se agrega al contador per se le resta 1 (solo se toma la parte par del conteo de cada letra impar) y la bandera cambia a true.
 * 5. Si la bandera es true, agregar 1 al contador (para el caracter central del palindromo).
 * 6. Retornar el contador.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class LongestPalindrome_409
    {
        public int LongestPalindrome(string s)
        {
            var counterLetters = new Dictionary<char, int>();
            var counter = 0;
            var haveNone = false;
            foreach (var c in s)
            {
                if (counterLetters.ContainsKey(c))
                {
                    counterLetters[c] += 1;
                }
                else
                {
                    counterLetters.Add(c, 1);
                }
            }
            foreach (var c in counterLetters)
            {
                if (c.Value % 2 == 0)
                {
                    counter += c.Value;
                }
                else
                {
                    counter += c.Value - 1;
                    haveNone = true;
                }
            }
            if (haveNone)
            {
                counter += 1;
            }
            return counter;
        }
    }
}
