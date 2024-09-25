using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
   internal class REVERSE_ARRAY
    {
        static void Main()
        {
            string s = "Anil Metakari";
            int i = s.Length - 1;
            string reverse = "";
            Console.WriteLine("Given String:" + s);
            while (i >= 0)
            {
                reverse += s[i];
                i -= 1;
            }
            Console.WriteLine("the reverse string is: " + reverse);
        }
    }
}
