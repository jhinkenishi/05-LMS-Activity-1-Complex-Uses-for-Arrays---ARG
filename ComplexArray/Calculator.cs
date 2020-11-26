using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexArray
{
    class Calculator
    {
        CustomMath math = new CustomMath();
        List<int> numberList = new List<int>();
        public Calculator()
        {

        }

        public int add(int num)
        {
            numberList.Add(num);
            int[] numbers = numberList.ToArray();
            return math.sumOf(numbers);
            
        }
    }
}
