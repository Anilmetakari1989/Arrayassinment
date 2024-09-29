using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class Person1
    {
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public void DisplayPersonInfo()
        {
            Console.WriteLine("Name="+Name);
            Console.WriteLine("Age="+Age);
        }
    }
    class Teacher : Person1
    {
        public string Subject { get; set; }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine("Subject=" + Subject);
        }
    }
    class Principal : Teacher
    {
        public int Experience { get; set; }

        public void DisplayPrincipalInfo()
        {
          Console.WriteLine($"Experience ={Experience} year");
        }
    }

    internal class MultilevelInheritance
    {
        static void Main()
        {
            Principal principal = new Principal();
            principal.Name = "Anil";
            principal.Age = 32;
            principal.DisplayPersonInfo();
            principal.Subject = "Dot Net";
            principal.DisplayTeacherInfo();
            principal.Experience = 4;
            principal.DisplayPrincipalInfo();

        }
    }
}
