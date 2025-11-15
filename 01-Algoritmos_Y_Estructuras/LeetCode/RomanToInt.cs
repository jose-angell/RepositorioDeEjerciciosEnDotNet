using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 13 Roman to Integer
 * Convertir un numero romano a su equivalente en numero int
 * simbolo   valor 
 *  I       1
 *  V       5
 *  X       10
 *  L       50
 *  C       100
 *  D       500
 *  M       1000
 * 
 * I puede estar antes de V(5) y X(10) para hacer 4 y 9
 * X puede estar antes de L(50) y C(100) para hacer 40 y 90
 * C puede estar antes de D(500) y M(1000) para hacer 400 y 900
 * 
 * Solucion 
 * 1. Inicializar: Crear un Dictionary<char, int> para almacenar el valor de cada símbolo
 * 2. Inicializar Resultado: total = 0
 * 3. Inicializar Puntero: Recorrer la cadena s desde el inicio (izquierda)
 * 4. Lógica del Loop (Iteración $i$):
        a. Obtener el valorActual (símbolo en la posición i).
        b. Obtener el valorSiguiente (símbolo en la posición i+1), si existe.
        c. Regla de Sustracción: Si el valorActual es menor que el valorSiguiente: Restar el valorActual del total (ej. si tienes 'I' antes de 'V').
        d. Regla de Adición: Si el valorActual es mayor o igual que el valorSiguiente:
 * Sumar el valorActual al total.
 * 5. Finalizar: Retornar total
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RomanToInt
    {
        public int solution(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000}
            };
            int total = 0;
            for( int i = 0; i < s.Length; i++)
            {
                int valorActual = romanMap[s[i]];
                if(i < s.Length - 1)
                {
                    int valorSiguiente = romanMap[s[i + 1]];
                    if(valorActual < valorSiguiente)
                    {
                        total -= valorActual;
                    }
                    else
                    {
                        total += valorActual;
                    }
                }
                else
                {
                    total += valorActual;
                }
            }
            return total;
        }
    }
}
