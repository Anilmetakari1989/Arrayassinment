using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    public enum Year
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

    }
    internal class Enum1
    {
        static void Main()
        {
            Console.WriteLine("Enter Month");
            string x= Console.ReadLine().ToString();
            Year month =( Year)Enum.Parse(typeof(Year),x);
           
            switch(month)
            {
                    case Year.January:
                    Console.WriteLine("you entered January month");
                    break;
                    case Year.February:
                   Console.WriteLine("you entered February month");
                    break;
                    case Year.March:
                    Console.WriteLine("you entered March month");
                    break;
                    case Year.May:
                    Console.WriteLine("you entered May month");
                    break;
                    case Year.June:
                    Console.WriteLine("you entered June month");
                    break;  
                    case Year.July:
                    Console.WriteLine("you entered July month");
                    break;
                    case Year.August:
                    Console.WriteLine("you entered August month");
                    break;
                    case Year.September:
                    Console.WriteLine("you entered September month");
                    break;
                    case Year.October:
                    Console.WriteLine("you entered October month");
                    break;
                    case Year.November:
                    Console.WriteLine("you entered November month");
                    break;
                    case Year.December:
                    Console.WriteLine("you entered December month");
                    break;
            }
            if (month == Year.December)
            {
                Console.WriteLine("This is last Month of Year");
            }
            else if (month == Year.January)
            {
                Console.WriteLine("This is First Month of Year");
            }
            else
            {
                Console.WriteLine("Month of Year");
            }

        }
    }
}
