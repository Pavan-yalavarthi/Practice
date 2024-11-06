using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class StringLength
    {
        static void Main(string[] args)
        {
                StringLen();
                Console.Read();
            }

            public static void StringLen()
            {
                  Console.WriteLine("Enter the word...");
                 string str = Console.ReadLine();
            Console.WriteLine("Length is "+str.Length);

            }
        }
}
