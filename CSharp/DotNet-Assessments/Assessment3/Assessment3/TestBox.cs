using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Box
    {
        public double Length;
        public double Breadth;

        public static Box Add(Box box1, Box box2)
        {
            return new Box
            {
                Length = box1.Length + box2.Length,
                Breadth = box1.Breadth + box2.Breadth
            };
        }
    }

    class TestBox
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();

            Console.WriteLine("Dimensions for Box 1:");
            Console.Write("Length: ");
            b1.Length = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            b1.Breadth = double.Parse(Console.ReadLine());

            Console.WriteLine("Dimensions for Box 2:");
            Console.Write("Length: ");
            b2.Length = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            b2.Breadth = double.Parse(Console.ReadLine());

            Box b3 = Box.Add(b1, b2);
            Console.WriteLine($"Box 3 Details: Length = {b3.Length}, Breadth = {b3.Breadth}");
            Console.Read();
        }
    }
}

