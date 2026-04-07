using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 389. Find the Difference
 * Dados dos strings s y t, donde t es generado al mezclar los caracteres de s y agregar un caracter adicional, retornar el caracter adicional que se agregó a t.
 * Input: s = "abcd", t = "abcde"
 * Output: "e"
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class FindTheDifference_389
    {
        /* Solucion O(n) y espacio O(1)
         * Se utiliza el operador XOR para comparar los caracteres de ambos strings, ya que el operador XOR devuelve 0 si ambos caracteres 
         * son iguales y devuelve el caracter adicional si es diferente.
         * 1 . Inicializar una variable code en 0
         * 2. Recorrer el string s y aplicar el operador XOR entre code y cada caracter de s, almacenando el resultado en code
         * 3. Recorrer el string t y aplicar el operador XOR entre code y cada caracter de t, almacenando el resultado en code
         * 4. Retornar el valor de code, que será el caracter adicional que se agregó a t, ya que los caracteres iguales se cancelarán entre sí y solo quedará el caracter adicional.
         * 
         * Nota:
         * El operador XOR es una operación bit a bit que devuelve 1 si los bits son diferentes y 0 si son iguales. Por lo tanto, al aplicar el operador XOR entre dos caracteres, se comparan sus valores ASCII y
         * se obtiene un resultado que representa la diferencia entre ellos. Si ambos caracteres son iguales, el resultado será 0, y si son diferentes, el resultado será el valor ASCII del caracter adicional que se agregó a t.
         * a ^ a = 0 (un nnumero xor consigo mismo da cero)
         * a ^ 0 = a (un numero xor con cero da el mismo numero)
         * El XOR es conmutativo y asociativo, lo que significa que el orden de los operandos no afecta el resultado. Por lo tanto, al aplicar el operador 
         * XOR entre todos los caracteres de s y t, los caracteres iguales se cancelarán entre sí, dejando solo el caracter adicional que se agregó a t.
         * 
         * esto solo funciona si hay exactamente un caracter diferente
         * No distinge posiciones, solo el valor del careacter.
         */
        public char FindTheDifference(string s, string t)
        {
            int code = 0;
            foreach (char c in s)
            {
                code ^= c;
            }
            foreach (char c in t)
            {
                code ^= c;
            }
            return (char)code;
        }
        /* Solucion O(n) y espacio O(n)
         * 1. Inicializar un diccionario para contar las apariciones de cada caracter en ambos strings
         * 2. Recorrer el string s y actualizar el diccionario con las apariciones de cada caracter
         * 3. Recorrer el string t y actualizar el diccionario con las apariciones de cada caracter
         * 4. Recorrer el diccionario y encontrar el caracter que tiene una aparicion de 1, ese será el caracter adicional que se agregó a t, ya que los caracteres iguales tendrán una aparicion de 2 y el caracter adicional tendrá una aparicion de 1.
         * 5. Si termna sin un adicional se retorna un char vacio
         */
        public char FindTheDifference2(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach(char c in s)
            {
                dict.TryAdd(c, 0);
                dict[c]++;
            }
            foreach (char c in t)
            {
                dict.TryAdd(c, 0);
                dict[c]++;
            }
            foreach (var d in dict)
            {
                if(d.Value == 1) return d.Key;
            }
            return new char();
        }

    }
}
