using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment3
{
    class TextFile
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\infinite\CSharp\DotNet-Assessments\Assessment3\Assessment3file_Program.txt";
            Console.Write("Enter the text to append: ");
            string textAppend = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textAppend);
            }

            Console.WriteLine("Text appended successfully.");
            Console.Read();
        }
    }
}
