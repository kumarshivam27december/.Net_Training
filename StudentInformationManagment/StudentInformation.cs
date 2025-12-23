using System;
class StudentInformation
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public StudentInformation()
    {
        Name = "Hellen Doe";
        Age = 21;
        Grade = "A";
    }

    public StudentInformation(string Name,int Age,string Grade)
    {
        this.Name = Name;
        this.Age = Age;
        this.Grade = Grade;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"your name is {Name}");
        Console.WriteLine($"your age is {Age}");
        Console.WriteLine($"your grade is {Grade}");
    }
    


}