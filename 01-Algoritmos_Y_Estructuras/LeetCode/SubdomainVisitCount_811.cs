using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 811. Subdomain Visit Count
 * Dado un Array de direcciones web, cuente el numero de visitas a cada subdominio. El formato de cada dirección web es "count domain.com", donde count es
 * el numero de visitas a ese dominio, y domain.com es el dominio visitado. Un subdominio de un dominio es aquel que se encuentra a la derecha del dominio, por ejemplo, 
 * "mail.yahoo.com" es un subdominio de "yahoo.com". El resultado debe ser un Array de Strings en el formato "count subdomain.com", donde count es el numero de visitas
 * a ese subdominio, y subdomain.com es el subdominio visitado. El orden del resultado no importa.
 * Input: ["9001 discuss.leetcode.com"]
 * Output: ["9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"]
 * 
 * Solucion
 * 1. Crear un diccionario para almacenar el numero de visitas a cada subdominio.
 * 2. Crear una lista para almacenar el resultado.
 * 3. Recorrer el Array de diccionarios, para cada direccion web, separar el dominio de las visitas
 *    - Para cada subdominio del dominio, validar si el subdominio ya existe en el diccionario, 
 *    - Si existe, sumar las visitas al valor existente, si no existe, agregar el subdominio al diccionario con el numero de visitas.
 *    - Para procesar cada subdiminio, se puede usar un ciclo while para ir eliminando el subdominio mas a la izquierda, hasta que no queden mas subdominios.
 * 4. Recorrer el diccionario y agregar cada subdominio y su numero de visitas a la lista de resultado en el formato "count subdomain.com".
 * 5. Retornar la lista de resultado.
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class SubdomainVisitCount_811
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dict = new Dictionary<string, int>();
            var result = new List<string>();
            foreach (string domain in cpdomains)
            {
                int count = int.Parse(domain.Split(" ")[0]);
                string subdomain = domain.Split(" ")[1];
                while (subdomain != "")
                {
                    if (dict.ContainsKey(subdomain))
                    {
                        dict[subdomain] += count;
                    }
                    else
                    {
                        dict.Add(subdomain, count);
                    }
                    var index = subdomain.IndexOf(".");
                    subdomain = index == -1 ? "" : subdomain.Substring(index + 1);
                }
            }
            foreach (var domain in dict)
            {
                result.Add(domain.Value.ToString() + " " + domain.Key);
            }
            return result;
        }
    }
}
