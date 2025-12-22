using System;
class Employee  //internal access modifier by default
{
    //int age -> private by default
    //members also private by default
    private int employeeId = 0;
    private string employeeName = string.Empty;
    
    private string departmentName = string.Empty;

    //naming convention
    private float _salary = 0.0f;

    private bool _status = true;


    public int empId  //empid property
    {
        get
        {
            return employeeId;
        }
        set
        {
            employeeId = value;
        }
    }


    public string EmpName
    {
        get
        {
            return employeeName;
        }
        set
        {
            employeeName = value;   
        }
    }



    public string depName
    {
        get
        {
            return departmentName;
        }
        set
        {
            departmentName = value;
        }
    }


    public float Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _salary = value;
        }
    }


    public bool Status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }




    




    public void AcceptDetails()
    {
        Console.WriteLine("Enter the Employee Details");
        Console.WriteLine("Enter the Employee Id");
        empId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Employee Name");
        EmpName = Console.ReadLine() ?? "";

        Console.WriteLine("Enter the Employee Department");
        depName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter the Employee Salary");
        Salary = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the Employee Status on Project :- True or False");
        Status = Convert.ToBoolean(Console.ReadLine());
    } 

    public void DisplayDetails()
    {
        Console.WriteLine("Employees Details Are");
        Console.WriteLine($"Employee Id is {empId}");
        Console.WriteLine($"Employee Name is {EmpName}");
        Console.WriteLine($"Employee Department is {depName}");
        Console.WriteLine($"Employee Salary is {Salary}");
        Console.WriteLine($"Employee Status is {Status}");

    }

}