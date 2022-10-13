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
            //defining queue
            Queue<int> queue = new Queue<int>();
            //add object to the end of queue
            queue.Enqueue(1);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(4);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(5);
            //priting the element at the front od queue
            Console.WriteLine(queue.Peek());

            //remove first element from the top 
            queue.Dequeue();
            Console.WriteLine(queue.Peek());



            Console.ReadKey();
        }
    }
}
