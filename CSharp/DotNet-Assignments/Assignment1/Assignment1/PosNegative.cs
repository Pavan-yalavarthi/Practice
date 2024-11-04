using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	public class PosNegtive
	{
		public static void Main(string[] args)
	{
            Console.WriteLine("Enter Number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		if (num1 > 0)
		{
			Console.WriteLine(num1 + " is Positive Number ");
		}
		else if (num1 < 0)
		{
			Console.WriteLine(num1 + " is Negative Number ");
		}
		else
		{
			Console.WriteLine(num1 + " is Invalid Number ");
		}
		Console.Read();
	}
}
}
