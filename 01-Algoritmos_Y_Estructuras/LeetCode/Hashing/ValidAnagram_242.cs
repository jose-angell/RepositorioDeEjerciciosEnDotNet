using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 242. Valid Anagram
/* Objetivo: teniendo como entrada dos string s y t, determinar si t es un anagrama de s
 * Entrada : s y t -> string
 * salida : booleano -> true si t es un anagrama de s, false en caso contrario
 *  
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ValidAnagram_242
    {
        public bool IsAnagram(string s, string t)
        {
            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();
            Array.Sort(ss);
            Array.Sort(tt);
            return new string(ss) == new string(tt);
        }
        public bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var charCount = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            foreach (var c in t)
            {
                if (!charCount.ContainsKey(c)) return false;
                charCount[c]--;
                if (charCount[c] < 0) return false;
            }
            return true;
        }
    }
}
