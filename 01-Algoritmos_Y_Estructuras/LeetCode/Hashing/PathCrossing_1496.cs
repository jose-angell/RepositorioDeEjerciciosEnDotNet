using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1496 Path Crossing
 * Dado un string de netrada que possee deplazamientos de un punto reprsentado por letras, N (norte), S (sur), E (este) W (oeste), devuelve true si se cruza en un puto
 * en mas de una ocacion y falso si solo pasa una vez por para aprte.
 * 
 * Input : path: NES
 * Output: false
 * 
 * Solucion:
 * 1.crear un hashset de tipo (int, int) para guardar las coordenadas, e inicializarlo con (0,0) el origen
 * 2. inicializar dos variable para guardar los desplazamientos en x,y
 * 3. recorrer cada letra del string
 * 4. validar que desplazamiento se esta dando y sumar o restar en x o y
 * 5. agreagar las coordenadas en el hashset, si da false, se retorna positivo a cruzar dos veces el mismo puto
 * 6. si el for termina se retora false.
 * 
 * 
 * 
 */


namespace _01_Algoritmos_Y_Estructuras.LeetCode.Hashing
{
    public class PathCrossing_1496
    {
        public bool IsPathCrossing(string path)
        {
            var dot = new HashSet<(int, int)>();
            int x = 0;
            int y = 0;
            dot.Add((x, y));
            foreach (char p in path)
            {
                if (p == 'N') y += 1;
                if (p == 'S') y -= 1;
                if (p == 'E') x += 1;
                if (p == 'W') x -= 1;
                if (!dot.Add((x, y))) return true;
            }
            return false;
        }
    }
}
