using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class SquareProgram
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            Console.WriteLine("Enter Numbers To Square");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Number {i + 1}");
                num.Add(int.Parse(Console.ReadLine()));
            }
            var res = from s in num
                      where s * s > 20
                      select s;
            foreach (var x in res)
            {
                Console.WriteLine($"{x} == {x * x}");
            }
            Console.ReadLine();

        }
    }
}
