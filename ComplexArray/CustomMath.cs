using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexArray
{
    class CustomMath
    {
        public CustomMath() { }

        public int sumOf(int[] num)
        {
            int total = 0;
            for(int i  = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total;
        }

     
    }
}
