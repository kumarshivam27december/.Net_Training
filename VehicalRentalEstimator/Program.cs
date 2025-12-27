using System;
class Program
{
    public static void Main(string[] args)
    {
    
        int days;
        int distance;
        bool withDriver;
        bool includeInsurance;
        
        int input;
        input = Convert.ToInt32(Console.ReadLine());

        VehicleCostEstimer vehicleCostEstimer = new VehicleCostEstimer();
        string vehicle;
        switch (input)
        {
            case 1:
                 vehicle = "Bike";
                 days = Convert.ToInt32(Console.ReadLine());
                 distance = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine($"The estimated rental cost of the {vehicle} is: ${vehicleCostEstimer.EstimateCost(days,distance)}");
                break;

            case 2:
                 vehicle = "Truck";
                 days = Convert.ToInt32(Console.ReadLine());
                 distance = Convert.ToInt32(Console.ReadLine());
                 withDriver = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine($"The estimated rental cost of the {vehicle} is: ${vehicleCostEstimer.EstimateCost(days,distance,withDriver)}");
                break;
            case 3:
                 vehicle = "Car";
                 days = Convert.ToInt32(Console.ReadLine());
                 includeInsurance = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine($"The estimated rental cost of the {vehicle} is: ${vehicleCostEstimer.EstimateCost(days,includeInsurance)}");
                break;
            default:
                Console.WriteLine("Input Invalid");
                break;
        }
    }
}