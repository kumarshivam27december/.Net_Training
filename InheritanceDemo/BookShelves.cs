using System;
class BookShelves : Furniture
{
    public override void Accept()
    {
        Console.WriteLine("enter no of shelves");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter color");
        color = Console.ReadLine() ?? "";

        Console.WriteLine("enter width");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter height");
        height = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
        Console.WriteLine($"no of shelves is {num}");
        Console.WriteLine($"color is {color}");

        Console.WriteLine($"width is {num}");
        Console.WriteLine($"height is {num}");
    }
}