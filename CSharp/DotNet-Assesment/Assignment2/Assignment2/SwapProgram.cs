using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SwapProgram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Numbers...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine()); ;
      
            Console.WriteLine("Number Before Swapping.. "+num1+" "+num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers After Swapping.. "+num1+" "+ num2);
            Console.Read();
        }
    }
}
