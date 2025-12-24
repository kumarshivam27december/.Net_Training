using System;
class Chair : Furniture
{
    public override void Accept()
    {
        Console.WriteLine("enter no of chair");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter color of chair");
        color = Console.ReadLine() ?? "";

        Console.WriteLine("enter width of chair");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter height of chair");
        height = Convert.ToInt32(Console.ReadLine());
    }
    

    public override void Display()
    {
        Console.WriteLine($"no of chair is {num}");
        Console.WriteLine($"color of chair is {color}");

        Console.WriteLine($"width of chair is  {num}");
        Console.WriteLine($"height of chair is  {num}");
    }
}