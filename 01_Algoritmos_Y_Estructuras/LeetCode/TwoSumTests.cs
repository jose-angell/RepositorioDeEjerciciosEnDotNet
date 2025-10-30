using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class TwoSumTests
    {
        [Fact]
        public void TwoSum_Should_ReturnIndicesForValidPair()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            // Act
            var actual = new LeetCode.TwoSum();
            var result = actual.Solution(nums, target);

            // Assert 
            Assert.Equal(expected, result);
            Assert.NotNull(result);
        }

        [Fact]
        public void TwoSum_Should_HandleNegativeNumbers()
        {
            // Arrange
            int[] nums = { -3, 4, 3, 90 };
            int target = 0;
            int[] expected = { 0, 2 };
            // Act
            var actual = new LeetCode.TwoSum();
            var result = actual.Solution(nums, target);
            // Assert 
            Assert.Equal(expected, result);
            Assert.NotNull(result);
        }

        [Fact]
        public void TwoSum_Should_ReturnEmptyArrayWhenNoPairFound()
        {
            // Arrange
            int[] nums = { 1, 2, 3 };
            int target = 8;
            int[] expected = { };

            // Act 
            var actual = new TwoSum();
            var result = actual.Solution(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
