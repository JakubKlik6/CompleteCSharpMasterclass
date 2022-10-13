using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace completeMasterclass
{
    internal class program
    {
        static void Main(string[] args)
        {
            
            //defining Stack 
            Stack<int> stack = new Stack<int>();
            //add new element
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                int i = stack.Pop();
                Console.WriteLine(i);
            }

            //printing value of the top
            Console.WriteLine("Top value in stack is {0}",stack.Peek());

            //removing item or stacking 
            stack.Pop();
            int newNumber = stack.Pop();
            

            int[]  numbers = {1,2,3,4,5,6};
            Stack<int> numbersStack = new Stack<int>();

            foreach (int number in numbers)
            {
                numbersStack.Push(number);
            }

            while (numbersStack.Count > 0)
            {
                int i = numbersStack.Pop();
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
