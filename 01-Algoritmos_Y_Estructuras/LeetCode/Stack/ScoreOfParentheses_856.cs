using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 856. Score of Parentheses
 * Dada una cadena de paréntesis balanceados, devuelve el puntaje de la cadena según las siguientes reglas:
 * 1. "()" tiene puntaje 1.
 * 2. AB tiene puntaje A + B, donde A y B son cadenas balanceadas.
 * 3. (A) tiene puntaje 2 * A, donde A es una cadena balanceada.
 * Solucion
 * 1. Crear una pila para almacenar los puntajes de los niveles de paréntesis.
 * 2. Inicializar la pila con un puntaje de 0 para el nivel más externo.
 * 3. Recorrer cada carácter en la cadena:
 *  - Si el carácter es '(', empujar un puntaje de 0 a la pila para representar un nuevo nivel.
 *  - Si el carácter es ')', hacer pop del puntaje del nivel actual, calcular el puntaje de este nivel según las reglas y sumarlo al puntaje del nivel anterior.
 * 4. Al final, el puntaje total estará en la cima de la pila.
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class ScoreOfParentheses_856
    {
        public int ScoreOfParentheses(string s)
        {
            var st = new Stack<int>();
            st.Push(0);
            foreach (char p in s)
            {
                if (p == '(')
                {
                    st.Push(0);
                }
                else
                {
                    int interior = st.Pop();
                    int puntajeNivel = Math.Max(2 * interior, 1);
                    int nivelAnterior = st.Pop();
                    st.Push(nivelAnterior + puntajeNivel);
                }
            }
            return st.Pop();
        }
    }
}
