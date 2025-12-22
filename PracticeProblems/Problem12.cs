class Problem12
{
    public static void Solve()
    {
        int studentNo;
        String name;
        int scienceMarks;
        int mathMarks;
        int englishMarks;
        int hindiMarks;
        int socialScienceMarks;
        int computerMarks;

        System.Console.WriteLine("Enter student rollno : ");
        studentNo = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter student name : ");
        name = System.Console.ReadLine() ?? "";

        System.Console.WriteLine("Enter student science marks : ");
        scienceMarks = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter student math marks : ");
        mathMarks = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter student english marks : ");
        englishMarks = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter student hindi marks : ");
        hindiMarks = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter student social science marks : ");
        socialScienceMarks = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter student computer marks : ");
        computerMarks = Convert.ToInt32(System.Console.ReadLine());


        int total = scienceMarks+englishMarks+mathMarks+hindiMarks+socialScienceMarks+computerMarks;
        double average = (total*1d)/(6d);

        System.Console.WriteLine("Result report");
        System.Console.WriteLine($"your total marks is {total}");
        System.Console.WriteLine($"your average marks is {average}");

        if (average >= (60d))
        {
            System.Console.WriteLine("first division");
        }else if (average >50d && average < 60d)
        {
            System.Console.WriteLine("second division");
        }
        else if(average>30d && average < 50d)
        {
            System.Console.WriteLine("third division");
        }
        else
        {
            System.Console.WriteLine("You failed \n try harder again \n better luck next time");
        }


    }
}