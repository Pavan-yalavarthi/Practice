using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class SelectName
    {
       static void Main()
        {
            Console.WriteLine("Enter Number of Strings..");
            int n = int.Parse(Console.ReadLine());
            List<string> str = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the string name {i + 1}");
                str.Add(Console.ReadLine());

            }

            var res = from name in str
                      where name.StartsWith("a") & name.EndsWith("m")
                      select name;
            Console.WriteLine("  ");
            foreach (var s in res)
            {
                Console.WriteLine("Result.. "+s);
            }
            Console.ReadLine();
        }

    }
}

