using System;
namespace PartialDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            PartialEmployee part = new PartialEmployee();
            part.FirstName = "shivam";
            part.LastName = "kumar";
            part.DisplayEmployeeDetails();
            part.DisplayFullName();
        }
    }
}