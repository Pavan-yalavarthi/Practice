using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TripleNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            if (num1 == num2)
            {
                int result = 3 * sum;
                Console.WriteLine(" Result = "+result);
            }
            else
            {
                Console.WriteLine(" Sum = "+sum);
            }
            Console.Read();
        }
    }
}
