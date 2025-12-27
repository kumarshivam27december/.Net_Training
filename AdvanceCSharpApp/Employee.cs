using System;
class Employee
{
    protected int employeeId ;
    protected int employeeAge;
    protected string employeeName = "";
    protected string employeeAddress = "";
    protected float employeeSalary;
    public virtual void GetEmployeeData()
    {
        Console.WriteLine("Enter Employee Data: ");
        Console.WriteLine("Enter the Id");
        employeeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name");
        employeeName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter employee address");
        employeeAddress =  Console.ReadLine() ?? "";
        Console.WriteLine("Enter the age");
        employeeAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the employeeSalary");
        employeeSalary = Convert.ToSingle(Console.ReadLine());
    }
    public virtual void DisplayEmployeeData()
    {
        Console.WriteLine("\n Employee details are");
        Console.WriteLine("Employee id is",employeeId);
        Console.WriteLine("Employee name is",employeeName);
        Console.WriteLine("Employee address is",employeeAddress);
        Console.WriteLine("Employee age is",employeeAge);
        Console.WriteLine("Employee Salary is",employeeSalary);
    }
    public virtual void CalculateSalary()
    {
        Console.WriteLine($"Employee salary is : {employeeSalary}");
    }
}
//by default all are sealed in base class