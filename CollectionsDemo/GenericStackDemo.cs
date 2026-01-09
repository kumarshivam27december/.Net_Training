using System.Collections.Generic;
class GenericStackDemo
{
    public static void Demo()
    {
        Stack<char> stack = new Stack<char>();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        stack.Pop();

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

    }
}