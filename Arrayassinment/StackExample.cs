using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassinment
{
    internal class StackExample
    {
        static void Main()
        {
            Stack stack= new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("HELLO");
            stack.Push(9975357411);
            stack.Push(false);
            stack.Push(10.5);
            Console.WriteLine("Total Elements in Stack ");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removed Elements from Stack");
            object firstElement = stack.Pop(); 
            object secondElement = stack.Pop();
            object thirdElement = stack.Pop();
            object forthElement = stack.Pop();
            object fifthElement = stack.Pop();
            object sixthElement = stack.Pop();
            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);
            Console.WriteLine(thirdElement);
            Console.WriteLine(forthElement);
            Console.WriteLine(fifthElement);
            Console.WriteLine(sixthElement);
            Console.WriteLine("Is stack empty:"+(stack.Count==0));

        }
    }
}
