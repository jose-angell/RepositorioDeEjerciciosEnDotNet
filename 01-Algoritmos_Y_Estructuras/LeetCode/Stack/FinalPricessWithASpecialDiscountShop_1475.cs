using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1475. Final Prices With a Special Discount in a Shop
 * dado un array de precios, donde el precio final de cada producto es igual a su precio original menos el precio del primer producto a su derecha 
 * que sea menor o igual a su precio original. Si no hay tal producto, entonces el precio final es igual al precio original.
 * 
 * 
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class FinalPricessWithASpecialDiscountShop_1475
    {
        public int[] FinalPrices(int[] prices)
        {
            var st = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                while (st.Count > 0 && prices[i] <= prices[st.Peek()])
                {
                    int idx = st.Pop();
                    prices[idx] -= prices[i];
                }
                st.Push(i);
            }
            return prices;
        }
    }
}
