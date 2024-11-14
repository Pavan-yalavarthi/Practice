using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment5
{
    class CountFile
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Dotnet_Practice\Filecount.txt";
            if (File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine("Number of Lines in the file is: {0}", count);
            }
            else
            {
                Console.WriteLine("Empty File...");
            }
            Console.Read();
        }
    }
}
