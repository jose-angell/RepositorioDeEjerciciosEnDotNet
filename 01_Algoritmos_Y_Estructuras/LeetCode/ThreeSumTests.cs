using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ThreeSumTests
    {
        public static IEnumerable<object[]> ThreeSumData =>
            new List<object[]>
            {
                    new object[]
                    {
                        new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>> { new List<int> { -1, -1, 2 },  new List<int> { -1, 0, 1 }},
                    },
                    new object[]
                    {
                        new int[] { 0, 1, 1 }, new List<IList<int>>() ,
                    },
                    new object[]
                    {
                        new int[] { 0, 0, 0, 0 }, new List<IList<int>> { new List<int> { 0, 0, 0 } }
                    }
            };
        [Theory]
        [MemberData(nameof(ThreeSumData))]
        public void ThreeSum_Should_ReturnTripletsForValidInput(int[] nums, List<IList<int>> expected)
        {
            //Acc
            var act = new ThreeSum();
            var result = act.Solution(nums);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
