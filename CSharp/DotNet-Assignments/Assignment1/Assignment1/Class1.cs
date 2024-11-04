using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                {
                Console.WriteLine(num1 +" and "+ num2 +" are equal");
            }
            else
            {
                Console.WriteLine(num1 +" and "+ num2 +" are not equal");
            }
                 Console.Read();
            
        }
    }
}
