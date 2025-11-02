using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/* Valid Palindrome  / validacion de palindromo
 * Una frase en un palindromo si, despues de convertir todas las detras mayusculas en minusculas  eliminar
 * todos los caracteres no alfanumericos (letras y numeros) se lee igual hacia adelante y hacia atras
 * 
 * entrada: como entrada se tien una variable de tipo string 's'
 * salida: la salida en un booleano true si es plindromo y false si no lo es
 * Patron Two Pointers: Punteros convergentes 
 * los punteros comienzan en los extremos opuestos de la estructura y se mueven hacia el centro (convergen)
 * 
 * 
 * El problema de la inmutabilidad (string)
 * En c# y .net, el tipo string es inmutable ( no se puede cambiar una vez creado)
 * 
 * Un objeto stringBuilder es mutable, 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ValidPalindrome
    {
        public bool Solution(string s)
        {
            var builder = new System.Text.StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    builder.Append(char.ToLower(c));
                }
            }
            string sClear = builder.ToString();
            int left = 0;
            int right = sClear.Length - 1;

            while (left < right)
            {
                if (sClear[left] != sClear[right])
                {
                    return false; // Si los caracteres no coinciden, no es palíndromo
                }
                left++;
                right--;
            }

            return true; // Si terminamos el ciclo, es palíndromo
        }

    }
}
