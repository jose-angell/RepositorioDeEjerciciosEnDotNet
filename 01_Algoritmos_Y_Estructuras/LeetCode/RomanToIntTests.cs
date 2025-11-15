using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class RomanToIntTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("IV", 4)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt_ReturnInt(string s, int i)
        {
            //act
            var act = new RomanToInt();
            var result = act.Solution(s);

            // Assert
            Assert.True(result == i);
        }

    }
}
