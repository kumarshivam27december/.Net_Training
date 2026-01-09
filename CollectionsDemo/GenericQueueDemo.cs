using System.Collections.Generic;
class GenericQueueDemo
{
    public static void Demo()
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        queue.Enqueue('D');
        queue.Enqueue('E');

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        queue.Dequeue();
        Console.WriteLine("After deque operation");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

    }
}