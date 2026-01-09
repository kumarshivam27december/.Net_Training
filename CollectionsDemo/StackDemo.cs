using System.Collections;
class StackDemo
{
    public static void Demo()
    {
        Stack stack = new Stack();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');
        stack.Push('F');

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        stack.Push('G');
        stack.Push('H');
        Console.WriteLine($"Top of the stack is {stack.Peek()} ");

        stack.Pop();//remove H
        stack.Pop();//remove G
        stack.Pop();//remove F
        stack.Pop();//remove E

        Console.WriteLine($"After popping top of the stack is {stack.Peek()}");

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Enter Element to find");
        char  ch = Convert.ToChar(Console.ReadLine() ?? " ");
        if (stack.Contains(ch))
        {
            Console.WriteLine($"Element {ch} Found");
        }
        else
        {
            Console.WriteLine("Element Not Found");
        }
    }
}