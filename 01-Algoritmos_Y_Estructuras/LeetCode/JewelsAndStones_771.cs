using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 771 Jewels and Stones
 * Dado dos arrays de caracteres jewels y stones, donde jewels representa los tipos de piedras preciosas, y stones representa las piedras que tienes en toltal,
 * contar cuantas priedas en stones son tambien joyas en jewels.
 * Input: jewels = "aA", stones = "aAAbbbb"
 * Output: 3    
 * Solucion O(n) tiempo y O(m) espacio adicional 
 * 1. Definir un HashSet para almacenar los tipos de joyas.
 * 2.Inicializar un contador en cero.
 * 3. Recorrer cada piedra en stones y verificar si es una joya.
 * 4. Si es una joya, incrementar el contador.
 * 5. Retornar el contador.
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class JewelsAndStones_771
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var hashJewels = new HashSet<char>(jewels);
            int count = 0;
            foreach (char s in stones)
            {
                if (hashJewels.Contains(s))
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
