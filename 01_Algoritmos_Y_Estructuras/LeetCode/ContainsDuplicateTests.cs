using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ContainsDuplicateTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 4, 5, 6, 7, 8, 9, 0 })]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 10, 1, 2, 3, 4, 5, 6, 8, 9, 0, 11 })]
        [InlineData(new int[] { 12, 23, 43, 64, 75, 86, 97, 80, 12, 19, 20 })]
        [InlineData(new int[] { 12, 23, 34, 40, 45, 55, 66, 17, 28, 39, 40 })]
        public void ContainsDuplicate_returnTrue(int[] nums)
        {
            // act
            var act = new ContainsDuplicate();
            var result = act.Solution(nums);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,5,6,7,8,9,0 })]
        [InlineData(new int[] {11,22,33,44,55,66,77,88,99,10,1,2,3,4,5,6,8,9,0 })]
        [InlineData(new int[] { 12, 23, 43, 64, 75, 86, 97, 80, 19, 20 })]
        [InlineData(new int[] { 12, 23, 34, 45, 55, 66, 17, 28, 39, 40 })]
        public void ContainsDuplicate_returnFalse(int[] nums)
        {
            // act
            var act = new ContainsDuplicate();
            var result = act.Solution(nums);

            // Assert
            Assert.False(result);
        }
    }
}
