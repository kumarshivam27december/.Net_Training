using System.Runtime.ConstrainedExecution;

class Task6
{
    public static void Solve()
    {
        Console.WriteLine("Enter the no of Operation");
        Queue<string> ProcessQueue = new Queue<string>();
        Stack<string> LastOperations = new Stack<string>();

        int noOfOperations = Convert.ToInt32(Console.ReadLine());
        int temp = noOfOperations;
        while(temp-- > 0)
        {
            string toDoTask = Console.ReadLine() ?? "";
            ProcessQueue.Enqueue(toDoTask);
            LastOperations.Push(toDoTask);
        }

        Console.WriteLine("Processing all queue in fifo order");

        while(ProcessQueue.Count > 0)
        {
            Console.WriteLine($"{ProcessQueue.Peek()}");
            ProcessQueue.Dequeue();
        }

        Console.WriteLine("Undo last 2 operations");

        for(int i = 0; i < 2; i++)
        {
            if(LastOperations.Count >0)
            {
                Console.WriteLine($"undo operation is {LastOperations.Peek()}");
                LastOperations.Pop();
            }
            else
            {
                Console.WriteLine("No operations left");
            }
        }

    }
}