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

        // Casos Límite y Fusión Inversa (nums1 es mayor)
        [InlineData(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]

        // Caso de Igualdad y Duplicados
        [InlineData(new int[] { 1, 1, 1, 0, 0, 0 }, 3, new int[] { 1, 1, 1 }, 3, new int[] { 1, 1, 1, 1, 1, 1 })]

        // Caso Mínimo
        [InlineData(new int[] { 1, 0 }, 1, new int[] { 2 }, 1, new int[] { 1, 2 })]
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
