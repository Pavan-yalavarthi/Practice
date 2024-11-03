using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CopyElements
    {
       static void Main(string[] args)
        {
            int[] arr1 = new int[4] { 12, 7, 5, 15 };
            int[] arr2 = arr1;
            for ( int i=0; i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]+ " ");
            }
            Console.ReadLine();
        }
    }
 }

