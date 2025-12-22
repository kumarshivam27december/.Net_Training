/*
13)program to read eno,ename,basic salary and calculate  
pf,hra,da,net salary and gross salary and print eno,ename,basic 
salary,
gross salary and net salary

pf= 12% of basic salary.
hra=20% of basic salary.
da= 15% of basic salary.
gross salary=pf+hra+da+basic salary;
net salary=gross salary - pf;

*/
using System;
class Manager
{
    private int _empNo = 0;
    private string _empName = string.Empty;
    private float _basicSal = 0.0f;


    public int EmpNO
    {
        get
        {
            return _empNo;
        }
        set
        {
            _empNo  = value;
        }
    }

    public string EmpName
    {
        get
        {
            return _empName;
        }
        set
        {
            _empName = value;
        }
    }

    public float BasicSal
    {
        get
        {
            return _basicSal;
        }
        set
        {
            _basicSal = value;
        }
    }

    private float _pf;
    private float _hra;
    
    private float _da;

    private float _grossSalary;

    private float _netSalary;


    public void AcceptDetails()
    {
        System.Console.WriteLine("Enter the Details");
        System.Console.WriteLine("Enter the Employee Id: ");
        EmpNO = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Employee Name: ");
        EmpName = Console.ReadLine() ?? "";
        System.Console.WriteLine("Enter the Employee basic Salary: ");
        BasicSal = Convert.ToSingle(Console.ReadLine());

    } 

    public void DisplayDetails()
    {
        System.Console.WriteLine($"welcome {EmpName}");
        System.Console.WriteLine($"your Employee Id is {EmpNO}");
        System.Console.WriteLine($"your basic salary is {BasicSal}");
        System.Console.WriteLine($"your pf  is {_pf}");
        System.Console.WriteLine($"your hra  is {_hra}");
        System.Console.WriteLine($"your da  is {_da}");
        System.Console.WriteLine($"your gross salary is {_grossSalary}");
        System.Console.WriteLine($"your net salary is {_netSalary}");
        
    }

    public void CalculateSalary()
    {
        _pf = (0.12f)*BasicSal;
        _hra = (0.2f)*BasicSal;
        _da = (0.15f)*BasicSal;
        _grossSalary = _pf+ _hra+ _da;
        _netSalary = _grossSalary - _pf;

    }
}