using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Contains Duplicate
 * Determinar si la lista de enteros posee numeros duplicados
 * Input: lista de numeros enteros
 * output: booleano 
 * Restricciones: 1 <= nums.Length <= 10^5,  -10^9 <= nums[i] <= 10^9
 * 
 * Solucion fuerza bruta
 * 1. establecer un ciclo for principal, i para recorresr la lista de enteros
 * 2. establecer un ciclo for anidado, j para recorrer la lista y comparar el elmento en i con dad elemento en j
 * 3. (Dentro del ciclo) condicional, i y j deben ser diferente posicion, si el elemento en j es igual al elemento en i
 *    retorna true para indicar que exite duplicados,
 * 4. Si el ciclo principal termina y no se encotro duplicados retorna flase.
 * 
 * Complegidad inical de O(n^2) y espacial de O(1)
 * 
 * cuello de botella: el tener un bucle anidado genera un costo de tiempo significativo cuando las entradas son grandes
 * Patron:
 * implementar Hashing (HashSet en C#) uso de un HashSet para verificacion de existencia en tiempo O(1), logrando una
 * solucion final O(N)
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ContainsDuplicate
    {
        public bool Solution(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            return nums.Length != numSet.Count;
        }
    }
}
