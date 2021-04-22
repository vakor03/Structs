using System;
using Structs.Lib;

namespace Structs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque<int>.StartedLength = 20;
            Deque<int> deque = new Deque<int>();
            for (int i = 0; i < 100; i++)
            {
                deque.AddToStart(i);
                deque.AddToEnd(i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(deque.PickFromStart());
                Console.WriteLine(deque.PickFromEnd());
            }
            
            
        }
    }
}