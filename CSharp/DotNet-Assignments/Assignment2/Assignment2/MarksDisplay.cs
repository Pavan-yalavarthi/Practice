using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MarksDisplay
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Array Size..");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array elements..");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            for (int i = 0; i < size; i++)
            {
                total = total + arr[i];

            }
            Console.WriteLine("Total.. "+total);
            int average_of_elements = total / size;
            Console.WriteLine("The average of elements is:" + average_of_elements);
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            Console.WriteLine("The minimum value is:" + arr[0]);
            Console.WriteLine("The maximum value is:" + arr[size - 1]);
            /*  for(int i = 0; i < size; i++)
              {
                  Console.WriteLine("Sorted numbers is:" + arr[i]);
              }*/
            for (int i=0; i<arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending order : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending order : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.Read();
        }
    }
}
