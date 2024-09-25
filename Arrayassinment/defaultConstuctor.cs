using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class defaultConstuctorExample
    {

        public int Age;
        public string Name;
        public defaultConstuctorExample()
        {

            Name = "Anil";
            Age = 35;

        }
        public void test()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Age=" + Age);
        }
        
    }
    internal class defoultConsctor
    {
        static void Main()
        {
            defaultConstuctorExample example = new defaultConstuctorExample();
            example.test();
            
        }
    }

}
