using System;
using System.Collections;
class Program
{
    static int shapeCount = 1;
    public static void Main(string[] args)
    {
        int userInput;
        userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput <= 0)
        {
            Console.WriteLine("Please enter a valid positive Integer");
            return;
        }
        Console.WriteLine("Areas of the Shape");
        while (userInput-->0)
        {
            string str = Console.ReadLine() ?? "";
            str = str.ToLower();
            switch (str)
            {
                case "circle":
                    double Radius = Convert.ToDouble(Console.ReadLine());
                    if (Radius <= 0)
                    {
                        Console.WriteLine("Invalid input for Radius. Please enter a numeric value.");
                    }
                    Shape shape = new Circle(Radius);
                    Console.WriteLine($"Area of Shape {shapeCount++} {str} is {shape.CalculateArea():F2}");
                    break;
                case "rectangle":
                    double Length = Convert.ToDouble(Console.ReadLine());
                    double Width = Convert.ToDouble(Console.ReadLine());
                    if (Length <= 0 || Width<=0)
                    {
                        Console.WriteLine("Invalid input for length or width. Please enter a numeric value.");
                    }

                    Shape shape1 = new Rectangle(Length,Width);
                    Console.WriteLine($"Area of Shape {shapeCount++} {str} is {shape1.CalculateArea():F2}");
                    break;
                default:
                    Console.WriteLine("Unknown shape type. Please enter rectangle or circle");
                    break;
            }
        }
    }
}