using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1436. Destination City
 *  Dato una lista de caminos entre ciudades, encontrar la ciudad destino, es decir, la ciudad que no es origen de ningun camino
 *  
 *  Input: paths = [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]
 *  Output: "Sao Paulo"
 *  
 *  Solucion: O(n) y espacio O(n)
 *  1. Inicializar un hashset para guardar las ciudades origen
 *  2. Recorrer la lista de caminos y agregar las ciudades origen al hashset
 *  3. Recorrer la lista de caminos y verificar si la ciudad destino no esta en el hashset, si no esta, retornar esa ciudad
 *  4. Si no se encuentra ninguna ciudad destino, retornar una cadena vacia
 * 
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class DestinationCity_1436
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var citySet = new HashSet<string>();
            foreach (var p in paths)
            {
                citySet.Add(p[0]);
            }
            foreach (var p in paths)
            {
                if (!citySet.Contains(p[1]))
                {
                    return p[1];
                }
            }
            return "";
        }
    }
}
