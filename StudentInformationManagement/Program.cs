using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfStudent = Convert.ToInt32(Console.ReadLine());
        while (numberOfStudent-- > 0)
        {
            int Id = Convert.ToInt32(Console.ReadLine());
            string Name = Console.ReadLine() ?? "";
            string Grade = Console.ReadLine() ?? "";

            Student student = new Student();
            student.Id = Id;
            student.Name = Name;
            student.Grade = Grade;

            StudentManager.AddStudent(student);
        }

        StudentManager.DisplayStudent();
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }
}

public class StudentManager
{
    static Dictionary<int, Student> Students = new Dictionary<int, Student>();

    public static void AddStudent(Student student)
    {
        Students.Add(student.Id, student);
    }

    public static void DisplayStudent()
    {
        Console.WriteLine("Student Information: ");

        foreach (KeyValuePair<int, Student> keyValuePair in Students)
        {
            Console.WriteLine($"Id: {keyValuePair.Value.Id}, Name: {keyValuePair.Value.Name}, Grade: {keyValuePair.Value.Grade}");
        }

    }
}

