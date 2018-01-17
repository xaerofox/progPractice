using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This exercise was to implement a queue by only using stacks.  Basically you can utilize 2 stacks and essentially "flip" 1 stack into another.
 * Flipping by pushing intended elements into the inbox stack or ENQUEUE. To DEQUEUE, Pop all elements from the outbox stack.  This will
 * put the reverse the elements in the first stack, but we must finish off any elements in the outbox before popping elements in the 
 * inbox. 
 * */

namespace CS_CodingPractice
{
    class FakeQueue
    {
        private Stack<int> inbox = new Stack<int>();
        private Stack<int> outbox = new Stack<int>();

        public void enqueue(int item)
        {
            inbox.Push(item);
        }

        public void dequeue()
        {
            if (!outbox.Any())
            {
                while (inbox.Any())
                {
                    outbox.Push(inbox.Pop());
                }
            }
            else outbox.Pop();
        }

        public void front()
        {
            if(!outbox.Any())
            {
                while (inbox.Any())
                    outbox.Push(inbox.Pop());
            }

            Console.WriteLine(outbox.Peek());
        } 

        public bool isEmpty()
        {
            return !inbox.Any() && !outbox.Any();
        }

        //public static void Main()
        //{
        //    fakeQueue queue = new fakeQueue();

        //    queue.enqueue(1);
        //    queue.enqueue(3);
        //    queue.enqueue(4);
        //    queue.enqueue(5);
        //    queue.front();

        //    while (!queue.isEmpty())
        //        queue.dequeue();

        //    Console.WriteLine("Queue status: " + queue.isEmpty());


        //}
    }
}
