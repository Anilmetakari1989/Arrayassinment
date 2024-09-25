using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class Calculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x,int y, int z)
        {
            return x + y + z;   
        }
        public double add(double x, double y, double z) 
        {
            return x + y + z; 
        }

    }
    internal class Static_Polymorphism
    {
        static void Main()
        {
            Calculator c = new Calculator();
            int sum1 = c.add(10, 20);
            int sum2 = c.add(10, 20, 30);
            double sum3 = c.add(10.5, 20.5, 30.5);
            Console.WriteLine("Sum of two int number:"+sum1);
            Console.WriteLine("Sum of three int number:"+sum2);
            Console.WriteLine("Sum of three double number:"+sum3);
        }

    }
}
