using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RemoveElementTests
    {
        [Fact]
        public void RemoveElement_CasoBase()
        {
            // Arrange
            int[] nums = { 1,2,3,4,5,6,4,32,1};
            int val = 1;
            int expected = 7;
            // Act
            var act = new RemoveElement();
            var result = act.Solution(nums, val);

            // Assert
            Assert.Equal(result, expected);

        }
        [Fact]
        public void RemoveElement_CasoNoTieneNingunValorDiferenteDeVal()
        {
            // Arrange
            int[] nums = { 1,1,1,1,1,1,1,1 };
            int val = 1;
            int expected = 0;
            // Act
            var act = new RemoveElement();
            var result = act.Solution(nums, val);

            // Assert
            Assert.Equal(result, expected);

        }
        [Fact]
        public void RemoveElement_CasoTodosSonDiferentesDeVal()
        {
            // Arrange
            int[] nums = { 1,2,3,4,5,6,7};
            int val = 0;
            int expected = 6;
            // Act
            var act = new RemoveElement();
            var result = act.Solution(nums, val);

            // Assert
            Assert.Equal(result, expected);

        }
        [Fact]
        public void RemoveElement_CasoNumsEsNull()
        {
            // Arrange
            int[] nums = null;
            int val = 0;
            int expected = 0;
            // Act
            var act = new RemoveElement();
            var result = act.Solution(nums, val);

            // Assert
            Assert.Equal(result, expected);

        }
    }
}
