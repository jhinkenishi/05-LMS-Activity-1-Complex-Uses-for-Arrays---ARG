using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creates an integer array and displays the sum of all its element values.");
            int[] nums = { 5, 1, 4, 7, 7, 1, 1, 31 };
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine("+");
                total += nums[i];
            }
            
            Console.WriteLine("Total: " + total);
            Calculator calculator = new Calculator();
            Console.WriteLine("Add a number: ");
            try
            {
                Console.WriteLine("7 times addition");
                int num = Convert.ToInt32(Console.ReadLine());
                calculator.add(num);
                Console.WriteLine("+");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+");
                calculator.add(num);
                num = Convert.ToInt32(Console.ReadLine());
                calculator.add(num);
                Console.WriteLine("+");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.add(num);
                Console.WriteLine("+");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.add(num);
                Console.WriteLine("+");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.add(num);
                Console.WriteLine("+");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + calculator.add(num));
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid! " + e.Message);
            }

        }
    }
}
