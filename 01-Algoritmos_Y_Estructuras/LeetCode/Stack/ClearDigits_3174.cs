using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 3174. Clear Digits
 * Dado un string s que consiste en letras y dígitos, elimina cada dígito que tenga una letra inmediatamente a su izquierda.
 * 
 * Solucion
 * 1. Crear una pila para almacenar los caracteres del string.
 * 2. Recorrer el string y para cada caracter, verificar si es un dígito y si la pila no está vacía y el caracter en la cima de la pila es una letra. Si es así, eliminar el caracter en la cima de la pila. De lo contrario, agregar el caracter a la pila.
 * 3. Al final, construir el string resultante a partir de los caracteres en la pila.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class ClearDigits_3174
    {
        public string ClearDigits(string s)
        {
            var st = new Stack<char>();
            foreach (char c in s)
            {
                if (st.Count > 0)
                {
                    if (Char.IsDigit(c) && Char.IsLetter(st.Peek()))
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(c);
                    }
                }
                else
                {
                    st.Push(c);
                }
            }
            var res = new StringBuilder();
            while (st.Count > 0)
            {
                res.Insert(0, st.Pop());
            }
            return res.ToString();
        }
    }
}
