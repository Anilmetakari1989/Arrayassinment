using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class EvenOdd_Number
    {
        static void Main()
        {
            int[] arr = { 5, 3, 8, 1, 4,6,7,9,2};
            string even = "";
            string odd = "";
            int Even= 0;
            Console.Write("Given number in Array:");
            int Odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2==0)
                {
                    even += arr[i];
                    //Console.WriteLine("Even number"+arr[i]);
                    Even++;
                }
                else
                {
                    odd+=arr[i];

                    //Console.WriteLine("odd number"+arr[i]);
                    Odd++;

                }
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Even numbers:  " +even);

            Console.WriteLine("Even number count:"+ Even);
            Console.WriteLine("Odd numbers:  " + odd);

            Console.WriteLine("Odd number count:" + Odd);
        }
    }
}
