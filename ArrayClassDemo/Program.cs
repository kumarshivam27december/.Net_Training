using System;
using System.Diagnostics.Tracing;
class Program
{
    public static void Main(string[] args)
    {

        Employee employee1 = new Employee() {Id = 30,Name = "Rajesh"};
        Employee employee2 = new Employee() {Id = 40,Name = "Suresh"};
        Employee employee3 = new Employee() {Id = 20,Name = "Mahesh"};
        Employee employee4 = new Employee() {Id = 60,Name = "Ganesh"};
        Employee employee5 = new Employee() {Id = 10,Name = "Jayesh"};

        Employee[] employeeList = new Employee[5];
        employeeList[0] = employee1;
        employeeList[1] = employee2;
        employeeList[2] = employee3;
        employeeList[3] = employee4;
        employeeList[4] = employee5;


        Console.WriteLine("Before Sorting");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

        Array.Sort(employeeList);

        Console.WriteLine("After Sorting");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }
        

        Console.WriteLine("Before Reversing");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

        Array.Reverse(employeeList);
        Console.WriteLine("After Reversing");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        int[] arr = new int[6] {50,20,30,10,40,60};
        Console.WriteLine($"Array Index of value 60 {Array.IndexOf(arr,60)}");
        Console.WriteLine($"Array value at index 3 {arr.GetValue(3)}");
        Console.WriteLine($"Array is fixed size {arr.IsFixedSize}");
        Console.WriteLine($"Array is read only {arr.IsReadOnly}");
        Console.WriteLine($"Array's rank {arr.Rank}");
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("Before sorting");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Array.Sort(arr);
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("After sorting");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("Before reversing");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("After reversing");
        Array.Reverse(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Program program = new Program();
        Employee employee = new Employee
        {
            Id = 90,
            Name = "Dinesh Kumar"
        };

        program.PassObject(employee);
        Employee employee6 = program.ReturnObject();
        Console.WriteLine(employee6);
        program.PassArrayObject(employeeList);
    }


    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id = 120,
            Name = "Suresh Kumarr"
        };
        return employee;
    }

    public void PassArrayObject(Employee[]  employee)
    {
        foreach (Employee e in employee)
        {
            Console.WriteLine(e);
        }
    }
    
}


/*
array properties like sort reverse getvalue getindexof rank length ......
return object 
custom class sort
pass value 
how to store array of class

*/