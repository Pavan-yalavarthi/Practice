using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator:");
            String operators = Console.ReadLine();
            Console.WriteLine("Enter Number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (operators == "+")
            {
                int sum = num1 + num2;
                Console.WriteLine(" Result = "+sum);
            }
            else if (operators == "*")
            {
                int prod = num1 * num2;
                Console.WriteLine("Result = "+prod);
            }
            else if (operators == "-")
            {
                int diff = num1 - num2;
                Console.WriteLine("Result = "+diff);
            }
            else if (operators == "/")
            {
                int div = num1 / num2;
                Console.WriteLine("Result = "+div);
            }
               Console.Read();
        }
    }
}
