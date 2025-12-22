class CaseBased3
{
    public static void Solve()
    {
        int marks;
        System.Console.WriteLine("Enter the marks between 0 to 100");
        marks = Convert.ToInt32(System.Console.ReadLine());
        char grades;

        if (marks > 90)
        {
            grades = 'A';
        }else if(marks>=80 && marks < 90)
        {
            grades = 'B';
        }else if(marks>=70 && marks < 80)
        {
            grades = 'C';
        }else if(marks>=60 && marks < 70)
        {
            grades = 'D';
        }
        else
        {
            grades = 'F';
        }

        System.Console.WriteLine($"Your grades is {grades}");
    }
}