using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class NegativeException
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                CheckForNegative(number);
                Console.WriteLine("The number is valid.");
            }
            catch (ArgumentOutOfRangeException ar)
            {
                Console.WriteLine($"Exception: {ar.Message}");
            }
            Console.Read();
        }

        static void CheckForNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "The number cannot be negative.");
            }
        }
    }
}
