using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 202. Happy Number
 * Dado un numero entero n, determinar si es un "happy number".
 * para saber si un numer es happy number, se debe reemplazar el numero por la suma de los cuadrados de sus 
 * digitos, y repetir el proceso hasta que el numero sea 1 (donde quedara feliz), o que entre en un ciclo que no
 * tiene el 1 (donde no sera feliz).
 * Input: n = 19
 * Outpt:  true
 * Solucion O(log n) y O(1) espacio adicional
 * 1. Crear una funcion para calcular la suma de los cuadrados de los digitos de un numero.
 * 2. Inicializar un HashSet para rastrear los numeros ya vistos.
 * 3. Mientras n no sea 1, calcular la suma de los cuadrados de sus digitos. y guardar esa suma en el hashSet 
 * 4. Si el numero ya existe en el hashSet, significa que estamos en un ciclo y retornamos false.
 * 5 . Si n llega a ser 1, retornamos true.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class HappyNumber_202
    {
        public bool IsHappy(int n)
        {
            var seen = new HashSet<int>();
            while(n != 1)
            {
                n = GetSumSquert(n);
                if (seen.Contains(n))
                {
                    return false;
                }
                seen.Add(n);
            }
            return true;
        }
        public int GetSumSquert(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var digit = n % 10; // obtiene el ultimo digito
                sum += digit * digit; // suma el cuadrado del digito
                n /= 10; // elimina el ultimo digito
            }
            return sum;
        }
    }
}
