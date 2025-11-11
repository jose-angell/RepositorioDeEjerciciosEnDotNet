using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RemoveDuplicatesTests
    {

        [Theory]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4})]
        public void RemoveDuplicates_returnConDuplicados(int[] nums)
        {
            // Act
            var act = new RemoveDuplicates();
            var result = act.Solution(nums);

            // Assert
            Assert.True(result < nums.Length);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void RemoveDuplicates_returnSinDuplicados(int[] nums)
        {
            // Act
            var act = new RemoveDuplicates();
            var result = act.Solution(nums);

            // Assert
            Assert.True(result == nums.Length);
        }
    }
}
