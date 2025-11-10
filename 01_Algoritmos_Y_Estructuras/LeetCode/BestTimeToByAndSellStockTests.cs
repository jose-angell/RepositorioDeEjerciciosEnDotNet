using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class BestTimeToByAndSellStockTests
    {

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 3, 7, 2 })]
        [InlineData(new int[] { 7, 6, 4, 3, 1,8 })]
        [InlineData(new int[] { 3, 2, 1, 5, 9 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })]
        [InlineData(new int[] { 1, 6, 4, 3, 1 })]
        public void BestTimeToByAndSellStock_returnBestProfit(int[] prices)
        {
            // Act
            var act = new BestTimeToByAndSellStock();
            var result = act.Solution(prices);

            // Assert
            Assert.NotNull(result);
            Assert.True(result > 0);
        }

        [Theory]
        [InlineData(new int[] { 8, 4, 3, 2, 1 })]
        [InlineData(new int[] { 7, 6, 4, 3, 1 })]
        [InlineData(new int[] { 6, 4, 3, 2, 1 })]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0})]
        public void BestTimeToByAndSellStock_returnZeroProfit(int[] prices)
        {
            // Act
            var act = new BestTimeToByAndSellStock();
            var result = act.Solution(prices);

            // Assert
            Assert.NotNull(result);
            Assert.True(result == 0);
        }
    }
}
