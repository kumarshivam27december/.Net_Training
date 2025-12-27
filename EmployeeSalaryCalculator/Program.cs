using System;
class Program
{
    public static void Main(string[] args)
    {
        int noOfEmployee;
        noOfEmployee = Convert.ToInt32(Console.ReadLine());
        if(noOfEmployee <= 0)
        {
            Console.WriteLine("please enter valid no of user (greater than 0)");
            return;
        }

        int tempNumber = noOfEmployee;


        Employee employee;
        double totalSalary;
        int employeeCount = 0;


        while (tempNumber-- > 0)
        {
            string typeOfEmployee;
            typeOfEmployee = Console.ReadLine() ?? "";
            double perHourCharge;
            perHourCharge = Convert.ToDouble(Console.ReadLine());
            double totalHourWorked;
            totalHourWorked = Convert.ToDouble(Console.ReadLine());

            typeOfEmployee = typeOfEmployee.ToLower();

            if (typeOfEmployee == "fulltimeemployee")
            {
                employee = new FullTimeEmployee();
                totalSalary = employee.CalculateSalary(perHourCharge,totalHourWorked);
                employeeCount++;
                Console.WriteLine($"Salary of Employee {employeeCount} {typeOfEmployee} :  {totalSalary}");
            }else if(typeOfEmployee  == "parttimeemployee")
            {
                employee = new PartTimeEmployee();
                totalSalary = employee.CalculateSalary(perHourCharge,totalHourWorked);
                employeeCount++;
                Console.WriteLine($"Salary of Employee {employeeCount} {typeOfEmployee} :  {totalSalary}");
            }else if(typeOfEmployee == "intern")
            {
                employee = new Intern();
                totalSalary = employee.CalculateSalary(perHourCharge,totalHourWorked);
                employeeCount++;
                Console.WriteLine($"Salary of Employee {employeeCount} {typeOfEmployee} :  {totalSalary}");
            }
            else
            {
                Console.WriteLine("invalid employee type");
                employeeCount++;
            }
        }
    }
}