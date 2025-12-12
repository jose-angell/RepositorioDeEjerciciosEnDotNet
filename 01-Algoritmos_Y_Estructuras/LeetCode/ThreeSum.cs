using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 15. Three Sum / Suma de tres numeros / 3Sum
 * Teniendo un array nums de n enteros, devuelve todas las tripletas [nums[i], nums[j], nums[k]]  que sumadas sea igual a 0
 * no se puede lumirar la misma tripleta mas de una vez
 * 
 * impunt: nums = [-1,0,1,2,-1,-4]
 * output: [[-1,-1,2],[-1,0,1]]
 * 
 * Solucion: complejidad O(n^2) y espacio O(n)
 * 1. Inicializar una lista para almacenar la solucion
 * 2.Ordenar el array de entrada in-place
 * 3. Iterar sobre el array con un indice i desde 0 hasta n-2
 * 4. saltar los elementos duplicados para i
 * 5. Inicializar dos punteros, j = i + 1 y k = n - 1
 * 6. Mientras left < right matener el ciclo while
 * 7. Calcular la suma de los tres elementos: sum = nums[i] + nums[j] + nums[k]
 * 8. Ajustar los punteros en bse a la suma, si es menor que 0, incrementar j, si es mayor que 0, decrementar k
 * 9. Si la suma es igual a 0, agregar la tripleta a la lista de solucion y mover j , validar y saltar los duplicados en j
 * 10. Retornar la lista de solucion
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ThreeSum
    {
        public IList<IList<int>> Solution(int[] nums)
        {
            var res = new List<IList<int>>();
            Array.Sort(nums);
            for(int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // saltar duplicados
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int total = nums[i] + nums[j] + nums[k];
                    if(total > 0)
                    {
                        k--;
                    }
                    else if(total < 0)
                    {
                        j++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++;
                        while (j < k && nums[j] == nums[j - 1]) j++; // saltar duplicados en j
                    }
                }
            }
            return res;
        }
    }
}
