using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class Scholarship
    {
        public double Merit(double fee, double marks)
        {
            double scholarAmmount =0;

            if (marks >= 70 && marks <= 80)
            {
                return scholarAmmount = 0.20 * fee;
            }
            else if (marks > 80 && marks <= 90)
            {
                return scholarAmmount = 0.30 * fee;
            }
            else if (marks > 90)
            {
                return scholarAmmount = 0.50 * fee;
            }
            else
            {
                Console.WriteLine("...No Scholar...");
            }
              return scholarAmmount;
        }
    }
    class ScholarMain
    {
        public static void Main()
        {
            Scholarship sc = new Scholarship();
            Console.WriteLine("Enter the Marks..");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Fee Ammount...");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sc.Merit(fee,marks));
            Console.Read();
        }
    }
}
