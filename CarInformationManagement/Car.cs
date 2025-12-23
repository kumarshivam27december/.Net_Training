using System;
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public int old { get; set; }
    public Car(string Make,string Model,int Year)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("car details: ");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");

    }

    public void DisplayAge()
    {
        old = 2025-Year;
        Console.WriteLine($"Car Age: {old} Years");
    }
}