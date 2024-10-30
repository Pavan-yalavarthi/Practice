using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Table
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=10; i++)
            {
                int num1 = num * i;
                Console.WriteLine(num +" * "+i+ " = " +num1 );
            }
            Console.Read();
        }
    }
}
