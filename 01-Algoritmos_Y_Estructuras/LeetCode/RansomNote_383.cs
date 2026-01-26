using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 383. Ransom Note
/* Objetivo: Teniendo dsos string ransomNote y magazine, determinar si ransomNote puede construirse a partir de las letras de magazine
 * Entrada : string ransomNote, string magazine
 * salida : booleano -> true si ransomNote puede construirse a partir de las letras de magazine, false en caso contrario 
 * 
 * Solucion: O(n) tiempo y O(1) espacio
 *  1. Recorrer cada caracter en ransomNote
 *  2. Para cada caracter, verificar si existe en magazine
 *  3. Si no existe, retornar false
 *  4. Si existe, eliminar ese caracter de magazine para evitar reutilizacion
 *  5. Si se recorren todos los caracteres de ransomNote sin problemas, retornar true
 */


namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RansomNote_383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            foreach (char c in ransomNote)
            {
                if (!magazine.Contains(c))
                {
                    return false;
                }
                else
                {
                    int idx = magazine.IndexOf(c);
                    if (idx != -1)
                    {
                        magazine = magazine.Remove(idx, 1);
                    }
                }
            };
            return true;
        }
    }
}
