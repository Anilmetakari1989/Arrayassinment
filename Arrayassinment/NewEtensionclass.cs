using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    static class NewEtensionclass
    {
        public static void Substraction(this Exesting_Extension o)
        {
            int sub;
            sub = o.a - o.b;
            Console.WriteLine("Substraction of two digit=" + sub);

        }
        public static void Mulitiplication(this Exesting_Extension o,int a,int b)
        {
            int mul;
            mul = a * b;
            Console.WriteLine("Multiplication  of two number=" + mul);
        }
        public static void Divison(this Exesting_Extension o ,int a,int b)
        {
            int div;
            div = a / b;
            Console.WriteLine("Diviion of two Number=" + div);

        }
    }
}
