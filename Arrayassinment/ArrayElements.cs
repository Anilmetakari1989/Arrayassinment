using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class ArrayElements
    {
        static void Main()
        {
            int[] arr = { 10, 29, 39, 1, 90, 35, 87, 54, 67, 34 };
            int min = arr[0];
            int max = arr[0];
            Console.Write("Array Elements :");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write( arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Alternate element : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
                if (min >= arr[i])
                {
                    min = arr[i];
                }
                if (max <= arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("number of element :" + arr.Length);
            Console.WriteLine("Smallest element :" + min);
            Console.WriteLine( "largest element :"+max);
        }
    }
}
