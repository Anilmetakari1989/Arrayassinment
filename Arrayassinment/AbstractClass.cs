using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    abstract class Shape
    {
        public abstract double CalculateArea(double a,double b);

        public void display()
        {
            Console.Write(" Calculate the Area of Circle:");

        }
        public void display1()
        {
            Console.Write(" Calculate the Area of Rectangle:");
        }
    }
    class Cricle : Shape
    {
        public override double CalculateArea(double a,double b)
        {
            return 3.14* a * a;
        }
    }
    class Rectangle: Shape
    {
        public override double CalculateArea(double a, double b)
        {
            return a*b;
        }
    }
    internal class AbstractClass
    {
        static void Main()
        {
            Cricle cricle = new Cricle();
            Rectangle rect = new Rectangle();
            cricle.display();
            double obj1 = cricle.CalculateArea(7.0, 0);
            Console.WriteLine(obj1);
            double obj2 = rect.CalculateArea(10.5, 5.0);
                rect.display1();
            Console.WriteLine(obj2);
        }
    }
}
