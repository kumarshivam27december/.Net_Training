public class Student
{
    public event Action<int> GradeChanged;
    public void UpdateGrade(int grade)
    {
        if(GradeChanged is not null)
        {
            GradeChanged(grade);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the grade");
        Student student = new Student();
        student.GradeChanged+=OnGradeChanged;
        try
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            student.UpdateGrade(temp);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid grade");
        }
    }
    public static void OnGradeChanged(int grade)
    {
        Console.WriteLine("Grade changed to : "+grade);
    }
}