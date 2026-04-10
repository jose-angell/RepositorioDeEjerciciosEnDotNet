using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2103. Rings and Rods
 * Dado un string rings que representa los anillos de colores colocados en 10 varillas numeradas del 0 al 9, cada 2 caracteres en rings representa un anillo de color y la varilla a la que está colocado. El primer carácter es el color del anillo ('R' para rojo, 'G' para verde, 'B' para azul) y el segundo carácter es el número de la varilla. Regresa el número de varillas que tienen anillos de los tres colores.
 * input: rings = "B0B6G0R6R0R6G9"
 * ouput: 1
 * solucion O(n)
 * 1. Crear un conjunto (HashSet) para almacenar los anillos únicos encontrados en el string rings.
 * 2. Recorrer el string rings de dos en dos caracteres (color y varilla) y agregar cada combinación al conjunto.
 * 3. Inicializar un contador para contar el número de varillas que tienen anillos de los tres colores.
 * 4. Para cada varilla del 0 al 9, verificar si el conjunto contiene las combinaciones de anillos de los tres colores (R, G, B) para esa varilla. Si es así, incrementar el contador.
 * 5. Regresar el contador como resultado final, que representa el número de varillas con anillos de los tres colores.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class RingsAndRods_2103
    {
        public int CountPoints(string rings)
        {
            HashSet<string> has = new HashSet<string>();
            int res = 0;
            for (int i = 0; i < rings.Length - 1; i += 2)
            {
                string sub = rings.Substring(i, 2);
                has.Add(sub);
            }
            if (has.Contains("R0") && has.Contains("G0") && has.Contains("B0")) res++;
            if (has.Contains("R1") && has.Contains("G1") && has.Contains("B1")) res++;
            if (has.Contains("R2") && has.Contains("G2") && has.Contains("B2")) res++;
            if (has.Contains("R3") && has.Contains("G3") && has.Contains("B3")) res++;
            if (has.Contains("R4") && has.Contains("G4") && has.Contains("B4")) res++;
            if (has.Contains("R5") && has.Contains("G5") && has.Contains("B5")) res++;
            if (has.Contains("R6") && has.Contains("G6") && has.Contains("B6")) res++;
            if (has.Contains("R7") && has.Contains("G7") && has.Contains("B7")) res++;
            if (has.Contains("R8") && has.Contains("G8") && has.Contains("B8")) res++;
            if (has.Contains("R9") && has.Contains("G9") && has.Contains("B9")) res++;
            return res;
        }
    }
}
