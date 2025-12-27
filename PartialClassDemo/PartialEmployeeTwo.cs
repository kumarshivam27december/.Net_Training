using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine("Full name is : {0} {1}",_firstName,_lastName);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("First name is {0}",_firstName);
            Console.WriteLine("Last name is {0}",_lastName);
            Console.WriteLine("Gender is {0}",_gender);
            Console.WriteLine("Salary is {0}",_salary);
        }

        partial void PartialMethod()
        {
            Console.WriteLine($"Partial method is invoked");
        }
    }
}