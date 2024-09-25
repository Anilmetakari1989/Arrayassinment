using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class Search_String
    {
        static void Main()
        {
            string[] name = { "Alice", "Bob", "charlie", "David", "Emily" };
            Console.WriteLine("Given String in Array is: ");
            foreach (string s in name)
            {
                Console.WriteLine(s + "\t");
            }
            Console.WriteLine("Enter the name Got be Search in the Array");
            string x = Console.ReadLine().ToString();
            string present = "";
            for (int i = 0; i < name.Length; i++) 
            {
                if (name[i] == x)
                { 
                  present = name[i];
                }
            }
            if(present == x)
            {
                Console.WriteLine($"{x} Is present in array");

            }
            else
            {
                Console.WriteLine($"Is not present in Array");
            }


        }
    }
}
