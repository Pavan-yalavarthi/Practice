using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SameString
    {
        static void Main(string[] args)
        {
            Same();
            Console.Read();
        }
        public static void Same()
        {
            Console.WriteLine("Enter the words..");
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            bool equal = true;
            if (str.Length != str1.Length)
            {
                equal = false;
            }
            else
            {
                for (int i=0; i<str.Length; i++)
                {
                    if (str[i] != str1[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }
            if (equal)
            {
                Console.WriteLine(str +" " +str1+" Two words are equal");
            }
            else
            {
                Console.WriteLine(str +" "+str1+" Are Not equal");
            }
        }
    }
}
