using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
   public class StackAndQueue
    {
        static void Main(string[] args)
        {
            var item = new Stack<string>();
            item.Push("1");
            item.Push("2");
            item.Pop();
            foreach (var i in item)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(item.Count);

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();

            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            
        }
    }
}
