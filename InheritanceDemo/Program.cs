using System;
using System.Runtime.CompilerServices;
class Program
{
    public static void Main(string[] args)
    {
        // Employee employee = new Employee
        // {
        //     EmployeeId = 101,
        //     Name = "Shivam", 
        //     Salary = 750000f
        // };

        // Console.WriteLine($"Employee id is {employee.EmployeeId}");
        // Console.WriteLine($"Employee name  is {employee.Name}");
        // Console.WriteLine($"Employee id is {employee.Salary}");

        // Console.WriteLine($"{employee}");


        // Program program = new Program();
        // program.Add(10,59);

        // program.Addition(101,1,1,2,3,3,4,4,5);

        // Console.ReadKey();
        
        //method overloading
        // Calculator calculator = new Calculator();
        // calculator.Add();
        // calculator.Add("shivam","");


        // double distance = 50.00;
        // double hour = 5.0;
        // double fuel = 10.0;

        // Vehicle vehicle = new Vehicle(distance,hour,fuel);
        // vehicle.Average(); //calling base class member method
        // vehicle.Speed(); //calling base class member method

        // Console.WriteLine();
        // Car car = new Car(distance,hour,fuel);
        // car.Average();
        // car.Speed();


        // Furniture furniture = new Furniture();//error cannot create the object of abstract class 
        Furniture furniture; //can create a reference variable


        
        BookShelves bookShelves = new BookShelves();
        bookShelves.Accept();
        bookShelves.Display();


        Chair chair = new Chair();
        chair.Accept();
        chair.Display();

    }


    public  void Add(int number1,int number2)
    {
        int sum = number1+ number2;
        Console.WriteLine($"{sum}");

    }


    public void Addition(params int[] arr) //parameter array Paramarray.
    {
        int total = 0;
        foreach(int num in arr)
        {
            total+=num;
        }

        Console.WriteLine($"Addition is {total}");
    }
}