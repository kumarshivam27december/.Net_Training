using System;
class Employee
{
    public int EmployeeId { get; set; }
    public  string EmployeeName { get; set; }

    public override string ToString()
    {
        return $"Employee id is {EmployeeId}"+$" Employee name is {EmployeeName}";
    }

}