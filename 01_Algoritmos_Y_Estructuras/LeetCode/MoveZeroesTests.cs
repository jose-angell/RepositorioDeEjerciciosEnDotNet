using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MoveZeroesTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0, 0, 1 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { }, new int[] { })]
        public void MoveZeroes_withSucces(int[] nums, int[] expected)
        {
            // Act
            var act = new MoveZeroes();
            act.Solution(nums);
            // Assert
            Assert.Equal(expected, nums);
        }
    }
}
