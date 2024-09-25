using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class String_Builder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(",");
            sb.Append("Everyone");
            string str1= sb.ToString();
            Console.WriteLine("Given String:"+ str1);
            sb.Replace("Hello", "Hi");
            string str2= sb.ToString();
            Console.WriteLine("Replace String Hello to Hi:" + str2);
            sb.Remove(3, 5);
            string str3= sb.ToString();
            Console.WriteLine("Remove string 3 to 5 :" + str3);
        }
    }
}
