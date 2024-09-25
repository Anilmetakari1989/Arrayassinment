using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class Primenumber
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17 };
            Console.WriteLine("Prime Number in the Araray are:");
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number + "  ");
                }
            }
        }
       
        static bool IsPrime(int num)
        {
            if(num <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num%i == 0)
                    return false;
            }
            return true;
        }
    }
}
