using System;
class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }

    public float Salary { get; set; }

    public Employee()
    {
        Name = string.Empty;
    }
    public Employee(int EmployeeId,string Name,float Salary)
    {
        this.EmployeeId = EmployeeId;
        this.Name = Name;
        this.Salary=Salary;
    }

    //overriding the tostring 
    public override string ToString()
    {
        return $"Employee details are \n"+ $"Employee id is {EmployeeId} \n" + $"Employee name is {Name} \n" + $"Employee salary is {Salary}";
    }
}