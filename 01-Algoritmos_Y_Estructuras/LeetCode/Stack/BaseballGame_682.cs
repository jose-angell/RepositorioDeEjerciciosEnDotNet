using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 682. Baseball Game
 * Dado una lista de cadenas que representan operaciones de puntuación de un juego de béisbol, calcula el puntaje total después de realizar todas las operaciones. 
 * Las operaciones pueden ser:
 * un entero (representando puntos obtenidos en una ronda),
 * '+' (representando que el puntaje de la ronda actual es la suma de los puntajes de las dos rondas anteriores),
 * 'D' (representando que el puntaje de la ronda actual es el doble del puntaje de la ronda anterior),
 * 'C' (representando que el puntaje de la ronda anterior se anula y no se cuenta para el puntaje total).
 * Regresa la suma total después de realizar todas las operaciones.
 * Input: ["5","2","C","D","+"]
 * Output: 30
 * Solución: O(n)
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class BaseballGame_682
    {
        public int CalPoints(string[] operations)
        {
            List<int> records = new List<int>();
            foreach (string operation in operations)
            {
                switch (operation)
                {
                    case "+":
                        if (records.Count < 2) continue;
                        records.Add(records[^1] + records[^2]);
                        break;
                    case "D":
                        if (records.Count < 1) continue;
                        records.Add(records[^1] * 2);
                        break;
                    case "C":
                        if (records.Count < 1) continue;
                        records.RemoveAt(records.Count - 1);
                        break;
                    default:
                        records.Add(int.Parse(operation));
                        break;
                };
            };
            return records.Sum();
        }
        public int CalPoints2(string[] operations)
        {
            int sum = 0;
            var scores = new Stack<int>();

            int pop()
            {
                if (scores.Count == 0)
                    return 0;
                sum -= scores.Peek();
                return scores.Pop();
            };
            void push(int x)
            {
                scores.Push(x);
                sum += x;
            };
            var actions = new Dictionary<string, Action>
            {
                ["+"] = () => { int tmpA = pop(), tmpB = pop(); push(tmpB); push(tmpA); push(tmpA + tmpB); },
                ["D"] = () => { int tmpA = pop(); push(tmpA); push(tmpA << 1); },
                ["C"] = () => pop()
            };

            foreach (var act in operations)
            {
                if (actions.ContainsKey(act))
                    actions[act]();
                else
                    push(Int32.Parse(act));
            }

            return sum;
        }
    }
}
