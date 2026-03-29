using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2325 . Decode the Message`
 * Dado un string key y un string message, decodificar el mensaje usando el key. El key se utiliza para crear un mapeo de caracteres, donde el primer caracter distinto de espacio en key se mapea a 'a', el segundo caracter distinto de espacio se mapea a 'b', y asi sucesivamente hasta mapear todos los caracteres distintos de espacio en key. Luego, cada caracter en message se reemplaza por su correspondiente caracter mapeado en key para obtener el mensaje decodificado.
 * Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
 * Output: "this is a secret"
 * 
 * Solucion O(n) tiempo y O(1) espacio adicional
 * 1. Crear un diccionario para mapear los caracteres distintos de espacio en key a los caracteres del alfabeto (a-z).
 * 2. Recorrer el string key y llenar el diccionario con los mapeos de caracteres, asegurándose de mapear solo los caracteres distintos de espacio y evitando mapeos duplicados.
 * 3. Recorrer el string message y construir el mensaje decodificado utilizando el diccionario para reemplazar cada caracter en message por su correspondiente caracter mapeado en key. Si un caracter en message no tiene un mapeo en el diccionario, se puede omitir o dejar sin cambios.
 * 4. Retornar el mensaje decodificado como resultado.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class DecodeTheMessage_2325
    {
        public string DecodeMessage(string key, string message)
        {
            var dic = new Dictionary<char, char>();
            var res = new StringBuilder();
            int a = 0;
            dic.Add(' ', ' ');
            for (int i = 0; i < key.Length; i++)
            {
                if (dic.TryAdd(key[i], (char)(97 + a)))
                {
                    a++;
                }

            }
            foreach (char m in message)
            {
                if (!dic.ContainsKey(m)) continue;
                res.Append(dic[m]);
            }
            return res.ToString();
        }
    }
}
