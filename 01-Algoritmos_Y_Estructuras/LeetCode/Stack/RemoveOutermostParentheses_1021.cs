using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode.Stack
{
    public class RemoveOutermostParentheses_1021
    {
        public string RemoveOuterParentheses(string s)
        {
            int open = 0;
            StringBuilder result = new StringBuilder();
            foreach (char c in s) { 
                if(c == '(')
                {
                    if(open > 0)
                    {
                        result.Append(c);
                    }
                    open++;
                }
                else if(c == ')')
                {
                    open--;
                    if(open > 0)
                    {
                        result.Append(c);
                    }
                }
            }
            return result.ToString();
        }
    }
}
