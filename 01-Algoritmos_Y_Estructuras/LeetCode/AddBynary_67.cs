using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 67. Add Binary
 * 
 * Teniendo dos strings binarios, retornar su suma como un string binario.
 * input: a = "11", b = "1"
 * output : "100"
 * solucion O(n) y O(1) espacio adicional
 * 1.Inicializar un StringBuilder para almacenar el resultado 'sum' y una variable 'carry' para el acarreo.
 * 2.Inicializar dos indices, 'indexA' y 'indexB', para recorrer los strings 'a' y 'b' desde el final.
 * 3.Mientras haya bits por procesar en 'a' o 'b' o haya un acarreo:
 *   asignar a 'BitA' el valor del bit actual de 'a' o 0 si 'indexA' es menor que 0.
 *   asignar a 'BitB' el valor del bit actual de 'b' o 0 si 'indexB' es menor que 0.
 *   Nota: Restar '0' convierte el caracter a su valor numérico.
 *   Sumar 'BitA', 'BitB' y 'carry' para obtener 'total'.
 *   asignar a 'sum' el bit resultante (total%2) al inicio del StringBuilder.
 *   Calcular el nuevo acarreo como total/2.
 * 4. Retornar el string resultante del StringBuilder 'sum'.
 *
 * Nota: Se utiliza StringBuilder para construir el resultado de manera eficiente. 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class AddBynary_67
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sum = new StringBuilder();
            int carry = 0;
            int indexA = a.Length - 1;
            int indexB = b.Length - 1;

            while (indexA >= 0 || indexB >=0 || carry > 0)
            {
                var BitA = indexA >= 0 ? a[indexA--] - '0' : 0;
                var BitB = indexB >= 0 ? b[indexB--] - '0' : 0;
                int total = BitA + BitB + carry;
                sum = sum.Insert(0,(total % 2).ToString());
                carry = total / 2;
            }


            return sum.ToString();
        }
    }
}
