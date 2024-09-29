using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class Shape1
    {
        public string Colorname { get; set; }

        public void Dispay1()
        {
            Console.WriteLine($"Shape Color Name= {Colorname}");
        }
    }
    class Circle1 : Shape1
    {
        public string ColorName { get; set; }
        public void Dispay2()
        {
            Console.WriteLine($"Circle Color Name={ColorName}");
        }

    }
    class Rectangle1 : Shape1
    {
        public string ColorName { get; set; }
        public void Dispay3()
        {
            Console.WriteLine($"Rectangle Color name={ColorName}");
        }
    }
    internal class HierarchicalInheritance
    {
        static void Main()
        {
            Circle1 circle1 = new Circle1();
            circle1.Colorname = "Red";
            circle1.Dispay1();
            circle1.ColorName = "Blue";
           circle1.Dispay2();
            Rectangle1 rectangle1 = new Rectangle1();
            rectangle1.Colorname = "White";
            rectangle1.Dispay1();
            rectangle1.ColorName = "Pink";
            rectangle1.Dispay3 ();


        }
    }
}
