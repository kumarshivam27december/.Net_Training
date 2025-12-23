using System;
class Program
{
    public static void Main(string[] args)
    {
        StudentInformation student1 = new StudentInformation();
        student1.DisplayDetails();

        string name;
        int age;
        string grade;
        Console.WriteLine("Enter the name: ");
        name = Console.ReadLine() ?? "";
        Console.WriteLine("Enter the age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the grade: ");
        grade = Console.ReadLine() ?? "";


        StudentInformation student2 = new StudentInformation(name,age,grade);
        student2.DisplayDetails();
        

    }
}