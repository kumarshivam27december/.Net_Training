using System;
class Program
{
    public static void Main(string[] args)
    {
        string make;
        string model;
        int year;
        make = Console.ReadLine()?? "";
        model = Console.ReadLine() ?? "";
        year = Convert.ToInt32(Console.ReadLine());
        Car car = new Car(make,model,year);
        car.DisplayDetails();
        car.DisplayAge();
    }
}