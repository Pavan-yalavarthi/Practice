using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class DelegateProgram
    {
        public delegate int CalculatorDelegate(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Select Operator:");
            Console.WriteLine("1=Addition");
            Console.WriteLine("2=Subtraction");
            Console.WriteLine("3=Multiplication");

            Console.Write("Select : ");
            int user = int.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorDelegate calculateDelegate = null;

            switch (user)
            {
                case 1:
                    calculateDelegate = Add;
                    break;
                case 2:
                    calculateDelegate = Subtract;
                    break;
                case 3:
                    calculateDelegate = Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    return;
            }

            int result = calculateDelegate(num1, num2);
            Console.WriteLine($"Result is : {result}");
            Console.Read();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
