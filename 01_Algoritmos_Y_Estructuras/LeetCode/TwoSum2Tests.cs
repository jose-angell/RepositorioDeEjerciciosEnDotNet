using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class TwoSum2Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 4, 9, 56, 90 }, 8, new int[] { 4, 5 })]
        [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
        [InlineData(new int[] { 25,5, 4, 75 }, 100, new int[] { 1, 4 })] // Solución en Extremos
        [InlineData(new int[] { 2, 5, 5, 11 }, 10, new int[] { 2, 3 })] // Duplicados (Solución 5+5)
        [InlineData(new int[] { 1, 5, 10 }, 12, new int[] { -1, -1 })] // Sin Solución (Caso de Falla)
        [InlineData(new int[] { -30, -10, 20 }, -40, new int[] { 1, 2 })] // Target Negativo (Suma de negativos)
        public void TwoSum2_withSucces(int[] numbers, int target, int[] expected)
        {
            // Act
            var act = new TwoSum2();
            var result = act.Solution(numbers, target);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
