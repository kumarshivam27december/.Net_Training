using System.Collections.Generic;
class GenericListDemo
{
    public static void Demo()
    {
        
        List<string> employeeName = new List<string>();
        employeeName.Add("Rajesh");

        Employee employee2 = new Employee(){ EmployeeId =20,EmployeeName = "Shivam"};
        Employee employee3 = new Employee(){ EmployeeId =21,EmployeeName = "Satyam"};

        List<Employee> employees = new List<Employee>();
        employees.Add(employee2);
        employees.Add(employee3);

        foreach (Employee e  in employees)
        {
            Console.WriteLine(e);
        }

    }
}