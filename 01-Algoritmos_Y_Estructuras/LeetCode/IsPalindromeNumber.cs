using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Is Palindrome Number
 * Validar si el numero x es un palidromo
 * Entrada x un numero entero, 
 * salida true o false, 
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class IsPalindromeNumber
    {
        public bool Solution(int x)
        {
            string val = x.ToString();
            int left = 0;
            int right = val.Length;
            while (left <= right)
            {
                if (val[left] != val[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
