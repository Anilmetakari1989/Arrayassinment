using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class ArrayListEx
    {
        static void Main()
        {
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(20);
            a.Add("Hello");
            a.Add(10.5);
            a.Add(50);
            a.Add(30);
            a.Add(50);
            a.Add(9975357411);
            a.Add(false);
            a.Add(40);
            Console.WriteLine("Total Elements of ArrayList");
            foreach(var items in a)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Remove the Elements Within ArrayList");
            a.Remove(false);
            a.RemoveAt(3);
            a.Reverse();


        foreach (var items in a)
            {
                Console.WriteLine(items);

            }   
        }
    }
}
