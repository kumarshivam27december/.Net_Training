using System;
class Manager : Employee
{
    double Bonus,CA;
    public override void GetEmployeeData()
    {
        Console.WriteLine("Enter Manger Data: ");
        Console.WriteLine("Enter the Id");
        employeeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name");
        employeeName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter the bonus");
        Bonus = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the ca");
        CA = Convert.ToDouble(Console.ReadLine());
    }
    public  override void DisplayEmployeeData()
    {
        Console.WriteLine("Manager details are");
        Console.WriteLine("Employee id is: "+employeeId);
        Console.WriteLine("Employee name is: "+employeeName);
        Console.WriteLine("Manager Bonus is: "+Bonus);
        Console.WriteLine("Manager CA is: "+CA);
    }
    public sealed  override void CalculateSalary()
    {
        Console.WriteLine("Manager salary is: "+employeeSalary);
    }
}