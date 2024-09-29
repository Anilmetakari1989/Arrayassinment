using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    class Preson
    {
        public String Name {  get; set; }
        public int Age { get; set; }
       public void display1()
        {
            Console.WriteLine("Display Student Imformation");
        }
    }
    class Student : Preson
    {
        public int Id { get; set; }
       public void display2() 
        {
                Console.WriteLine("Student Name:" + Name); 
            Console.WriteLine("Student Age:" + Age);
            Console.WriteLine("Student Id:"+Id);
        }
    }
    internal class SingleInheritance
    {
        static void Main()
        {
            Student student = new Student();
            student.Name = "Anil";
            student.Age = 32;
            student.Id = 10;
            student.display1();
            student.display2();

        }
    }
}
