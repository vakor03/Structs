using System;
using Structs.Lib;

namespace Structs.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            PriorQueue<int> queue = new PriorQueue<int>();
            queue.AddElement(12,5);
            queue.AddElement(13,4);
            queue.AddElement(15,6);
            queue.AddElement(13, 5);
            int priority = 6;
            Console.WriteLine(queue.GetByPriority(priority) != null
                ? String.Join(',', queue.GetByPriority(priority))
                : "No results!");
        }
    }
}