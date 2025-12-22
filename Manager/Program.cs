using System;
class Program
{
    public static void Main()
    {
        Manager manager = new Manager();
        manager.EmpName = "Rahul Kumar";
        manager.EmpNO = 12215334;
        manager.BasicSal = 15000f;
        manager.CalculateSalary();
        manager.DisplayDetails();

    }
}