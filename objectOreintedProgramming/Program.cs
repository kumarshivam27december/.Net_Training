using System;
class Program
{
    public static void Main(string[] args)
    {
        //creating the boject of Employee class
        // Employee employee = new Employee();
        // employee.AcceptDetails();//Binding the employee object with acceptdetials function
        // employee.DisplayDetails();//Binding the employee object with display details function
        
        
        // Employee employee1 = new Employee();
        // employee1.employeeId = 12215334;
        // employee1.employeeName = "Rahul Kumar";
        // employee1.departmentName = "Computer science and engineering";
        // employee1.salary = 5.75f;
        // employee1.status = true;

        // employee1.DisplayDetails();



        Employee employee2 = new Employee();
        // employee2.AcceptDetails();
        employee2.empId = 12215334;
        employee2.EmpName = "Rahul Kumar";
        employee2.depName = "CSE";
        employee2.Salary = 5.75f;
        employee2.Status = true;
        employee2.DisplayDetails();

        
        Console.ReadKey();
    }   
}