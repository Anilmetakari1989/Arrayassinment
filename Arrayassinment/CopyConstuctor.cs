using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class CopyConstuctorExample
    {




        public int Age, a;
        public string Name, n;
        public CopyConstuctorExample(String name, int age)
        {

            Name = name;
            Age = age;

        }
        public void test()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Age=" + Age);
        }
        public CopyConstuctorExample(CopyConstuctorExample copy)
        {

            n = copy.Name;
            a = copy.Age;

        }
        public void display()
        {
            Console.WriteLine("Name=" + n);
            Console.WriteLine("Age=" + a);

        }


    }




    internal class CopyConstuctor
    {
        static void Main(string[] args)
        {

            CopyConstuctorExample example = new CopyConstuctorExample("Anil", 32);
            example.test();
            CopyConstuctorExample ex = new CopyConstuctorExample(example);
            ex.display();
        }

    }
}
