using System;
class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.Name="Rahul Kumar";
        student.RegNO=12215334;
        student.ScienceMarks=97f;
        student.MathMarks=100f;
        student.HindiMarks=98f;
        student.EnglishMarks = 80f;
        student.ComputerMarks = 85f;
        student.SocialMarks = 81f;

        student.calculateMarks();
        student.displayDetails();
    }
}