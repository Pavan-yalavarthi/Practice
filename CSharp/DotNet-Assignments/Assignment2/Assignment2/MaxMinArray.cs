using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MaxMinArray
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
            int sum_of_elements = 0;
            for (int i = 0; i < size; i++)
            {
                sum_of_elements = sum_of_elements + arr[i];
                
            }
            int average_of_elements = sum_of_elements / size;
            Console.WriteLine("The average of elements is:" + average_of_elements);
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            Console.WriteLine("The minimum value is:" + arr[0]);
            Console.WriteLine("The maximum value is:" + arr[size-1]);
            Console.Read();
        }
    }
}
