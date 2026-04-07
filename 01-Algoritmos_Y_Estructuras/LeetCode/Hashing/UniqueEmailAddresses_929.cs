using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 929. Unique Email Addresses
 * Dado un array de strings emails, cada string emails[i] representa una dirección de correo electrónico. Se deben seguir las siguientes reglas para determinar si dos direcciones de correo electrónico son equivalentes:
 * para cada email se divide en dos partes, el nombre local y el dominio, separados por el simbolo '@'.
 * para el nombre local, se pueden ignorar los puntos '.' y se pueden ignorar los caracteres después de un signo '+' (incluido el signo '+').
 * estas reglas no se aplican al dominio.
 * 
 * Input: ["test.email+alex@leetcode.com","test.email.leet+alex@code.com"]
 * Output: 2
 * 
 * Solucion O(n) tiempo y O(n) espacio adicional
 * 1. Inicializar un HashSet para almacenar los emails unicos.
 * 2. Recorrer el array de emails y para cada email:
 *    Descomponer el email en nombre local y dominio utilizando el simbolo '@' como separador.
 *    Al nombre local , eliminar los puntos '.' y eliminar los caracteres despues del signo '+' (incluido el signo '+').
 *    Concatenar el nombre local modificado con el dominio para formar el email normalizado.
 *    validar si el email normalizado ya existe en el HashSet, si no existe agregarlo al HashSet.
 * 3. Retornar el tamaño del HashSet, que representa la cantidad de emails unicos.
 * 
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class UniqueEmailAddresses_929
    {
        public int NumUniqueEmails(string[] emails)
        {
            var setEmails = new HashSet<string>();
            foreach (string email in emails)
            {
                var localName = email.Split("@")[0];
                var domainName = email.Split("@")[1];
                localName = localName.Replace(".", "");
                localName = localName.Split("+")[0];

                if (!setEmails.Contains(localName + "@" + domainName))
                {
                    setEmails.Add(localName + "@" + domainName);
                }
            }
            return setEmails.Count;
        }
    }
}
