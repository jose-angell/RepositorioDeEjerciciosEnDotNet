using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1700. Number of Students Unable to Eat Lunch
 * 
 * solucion
 * 1. Contar cuántos estudiantes quieren cada tipo de sándwich, counts[0] para circulares, counts[1] para cuadrados
 * 2. Recorrer la pila de sándwiches uno por uno:  Si ya no quedan estudiantes que quieran este tipo de sándwich,la fila se estancará para siempre.
 * Si hay un estudiante disponible, se lo come y se reduce el contador
 * 3. El total de estudiantes que se quedaron sin comer es la suma de los que quedaron
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class NumerofStudentsUnabletoEatLunch_1700
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            
            int[] counts = new int[2]; 

            foreach (int student in students)
            {
                counts[student]++;
            }
            foreach (int sandwich in sandwiches)
            {
                if (counts[sandwich] == 0)
                {
                    break;
                }

                counts[sandwich]--;
            }

            return counts[0] + counts[1];
        }
    }
}
