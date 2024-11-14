using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment5
{
    class Files
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter string {i + 1}");
                str[i] = Console.ReadLine();
            }


            string path = "File.txt";
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(file);
            foreach (string s in str)
            {
                streamWriter.WriteLine(s);
            }
            Console.WriteLine("Files are stored");
            streamWriter.Flush();
            streamWriter.Close();
            streamWriter.Close();
            Console.ReadLine();
        }
    }
}
