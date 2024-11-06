using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Reverse();
            Console.Read();
        }
            public static void Reverse()
        {
            Console.WriteLine("Enter the word..");
            string str = Console.ReadLine();
            string reversed = "";
            for (int i=str.Length-1; i>=0; i--)
            {
                reversed = reversed +str[i];
            }
            Console.WriteLine(reversed) ;
        }
    }
}
