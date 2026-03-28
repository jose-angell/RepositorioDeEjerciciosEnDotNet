using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1624 Largest substring two equal characters
 * Dado un string de caracteres encontrar el substring mas grande entre dos letras iguales
 * Input: s ="abca"
 * Output: 2
 * Solucion
 * 1. crear un diccionario para almacenar el caracter y su indice, tambien inicializar la variable de respuesta en cero, y una vandera por si no existe un substring
 * 2. recorrere el string, y validar si ya existe en el diccionario entra en la condicional, y calcula el tamano del substring, y si es mayor que el actual se asigna a res
 * 3. se retorna res
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class LargestSubstringBetweenTwoEqualChar_1624
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var dic = new Dictionary<char, int>();
            int res = 0;
            int no = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.TryAdd(s[i], i))
                {

                    no = 0;
                    int dif = i - dic[s[i]] - 1;
                    if (dif > res)
                    {
                        res = dif;
                    }
                }
            }
            return res - no;
        }
    }
}
