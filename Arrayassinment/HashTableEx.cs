using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrayassinment
{
    internal class HashTableEx
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Hello");
            ht.Add(102,10.5);
            ht.Add(103, 5);
            ht.Add(104, false);
            ht.Add(105, 100);
            Console.WriteLine("Elements in Hashtable");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key{ entry.Key},Value: { entry.Value}");
            }
            ht.Remove(102);
            ht.Remove(104);
            Console.WriteLine("After removing Element of Hashtable");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"key{entry.Key},Value: {entry.Value}");

            
            }

        }
    }
}
