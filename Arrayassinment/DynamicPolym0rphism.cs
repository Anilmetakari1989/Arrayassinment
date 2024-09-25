using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape ");

        }
    }
    class Circle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

    }
    class Rectange:Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectange");
        }
    }
    internal class DynamicPolym0rphism
    {
        static void Main()
        {
            Animal obj1 = new Animal();
            Animal obj2 = new Circle();
            Animal obj3 = new Rectange();
            obj1.Draw();
            obj2.Draw();
            obj3.Draw();
        }
    }
}
