using System.Collections;
class QueueDemo
{
    public static void Demo()
    {
        Queue queue = new Queue();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        queue.Enqueue('D');

        foreach (var item in queue)
        {
           Console.WriteLine($" {item}"); 
        }

        queue.Dequeue();
        Console.WriteLine("\n\n\n After Deleting from Queue");

        foreach (var item in queue)
        {
            Console.WriteLine($" {item}");
        }

        if (queue.Contains('B'))
        {
            Console.WriteLine("queue is containing B");
        }
        else
        {
            Console.WriteLine("not found");
        }
        queue.Clear();

        Console.WriteLine("After clearing queue");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        
    }
}