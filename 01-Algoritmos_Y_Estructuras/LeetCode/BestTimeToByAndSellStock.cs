using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Best time to buy and sell stock
 * 
 * De una lista de precios ordenada por dia, se debe elegir el mejor dia para comprar stock y el mejor dia para vender, 
 * esto se determina con el mayor profit conseguido ( la diferencia entre los precios de cada dia)
 * 
 * input : int[] prices una lista de precios ordenada por dia, cada dumero representa el precio por dia
 * output: int, un numero que represente el valor de la mayor ganacia
 * [7,1,5,3,6,4]
 */

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class BestTimeToByAndSellStock
    {
        public int Solution(int[] prices)
        {
            int buy = prices[0];
            int profit = 0;
            for(int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                if ((prices[i] - buy) > profit)
                {
                    profit = prices[i] - buy;
                }
            }
            return profit;
        }

    }
}
