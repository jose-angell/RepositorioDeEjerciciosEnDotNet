using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  944 . Delete Columns to Make Sorted
 *  Dado un array de strings A, cada string tiene el mismo número de caracteres. Se pueden eliminar columnas de A para que las filas estén ordenadas lexicográficamente.
 *  Devuelve el número mínimo de columnas que se deben eliminar para que esto suceda.
 *  input: ["cba","daf","ghi"]
 *  output: 1
 *  
 *  
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class DeleteColumnsToMakeSorted_944
    {
        public int MinDeletionSize(string[] strs)
        {
            int res = 0;

            for (int col = 0; col < strs[0].Length; col++)
            {
                for (int row = 0; row < strs.Length - 1; row++)
                {
                    if (strs[row][col] > strs[row + 1][col])
                    {
                        res++;
                        break;
                    }
                }
            }
            return res;
        }


        public int MinDeletionSizeWithHashSet(string[] strs)
        {
            int columns = strs.First().Length;
            int n = strs.Length;
            HashSet<int> hs = new HashSet<int>();
            int removed = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (strs[i][j] > strs[i + 1][j])
                    {
                        if (!hs.Contains(j))
                        {
                            removed++;
                            hs.Add(j);
                        }
                    }
                }
            }
            return removed;
        }
    }
}
