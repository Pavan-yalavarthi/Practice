using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class FindLargestNum
    {
        public static int FindLargest(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the first integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int c = int.Parse(Console.ReadLine());

            int largest = FindLargest(a, b, c);
            Console.WriteLine(largest);
            Console.Read();
        }
    }
}
