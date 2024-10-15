using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class DictionaryExmple
    {
        static void Main(String[] args)
        {
            Dictionary<string,int> dict= new Dictionary<string,int>();
            dict.Add("Sachin", 21);
            dict.Add("Rahul", 22);
            dict.Add("Virat",23);
            dict.Add("Rohit", 24);
            dict.Add("Dipak", 25);
            dict.Add("Anil", 27);
            dict.Add("Sanjay", 26);
            dict.Add("Kapil", 29);
            dict.Add("laxman", 28);
            Console.WriteLine("Total Elements from Dictionary ");
            foreach(KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine($"key is :{kvp.Key},value is:{kvp.Value} ");

            }
            dict["Sachin"] = 31;
            dict["Anil"] = 32;
            Console.WriteLine();
            Console.WriteLine(" After Modified Elements from Disctionary");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"key is :{kvp.Key},value is:{kvp.Value} ");

            }Console.WriteLine();
            Console.WriteLine("Removed the specfic Elements from Dictionary");
            dict.Remove("Virat");
            dict.Remove("Dipak");

            dict.Remove("Laxman");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"key is :{kvp.Key},value is:{kvp.Value} ");

            }
            Console.WriteLine();
            Console.WriteLine("Filter the elements from Dictionary");
            if (dict.ContainsKey("Sachin"))
            {
                Console.WriteLine("Name is exit in Dictionary");
            }
                dict.Clear();

            Console.WriteLine("Total count of elements :" + dict.Count);



        }
    }
}
