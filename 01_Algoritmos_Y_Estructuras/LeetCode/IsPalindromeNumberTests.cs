using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class IsPalindromeNumberTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(121)]
        [InlineData(123454321)]
        public void IsPalindromeNumber_ReturnTrue(int x)
        {
            // Act
            var actua = new IsPalindromeNumber();
            var result = actua.Solution(x);

            // Assert
            Assert.True(result);
        }


        [Theory]
        [InlineData(-121)]
        [InlineData(123)]
        [InlineData(-1234554321)]
        public void IsPalindromeNumber_ReturnFalse(int x)
        {
            // Act
            var actua = new IsPalindromeNumber();
            var result = actua.Solution(x);

            // Assert
            Assert.False(result);
        }

    }
}
