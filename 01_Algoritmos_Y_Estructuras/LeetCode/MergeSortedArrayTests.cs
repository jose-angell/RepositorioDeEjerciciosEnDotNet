using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MergeSortedArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] {}, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 3,4,6, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 2, 3, 4, 5, 6, 6 })]
        public void MergeSortedArray_withSucces(int[] nums1, int m, int[] nums2, int n, int[] mergeArray)
        {
            // Act
            var act = new MergeSortedArray();
            act.Solution(nums1, m, nums2, n);

            // Assert
            Assert.Equal(nums1, mergeArray);
        }
    }
}
