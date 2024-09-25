using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class MinMax_Number
    {
        static void Main()
        {
            int[] arr = { 50, 30, 80, 10, 40 };
            int min = arr[0];
                Console.Write("Given number in Array:");
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]< min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                Console.Write(" "+arr[i]);
            }
          
            Console.WriteLine();
            Console.WriteLine("Minimum No:"+min);
            Console.WriteLine("Maxmum No:" + max);
        }
        
    }   
}
    
