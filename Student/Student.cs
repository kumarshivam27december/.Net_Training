using System;
class Student
{
   
    private int _regno = 0;
    private string _name =  "";
    private float _scienceMarks = 0.0f;
    private float _mathMarks = 0.0f;

    private float _socialMarks = 0.0f;
    private float _hindiMarks= 0.0f;
    private float _englishMarks= 0.0f;
    private float _computerMarks= 0.0f;


    private float total;
    private float average;
    private char division ;


    public int RegNO
    {
        get
        {
            return _regno;
        }
        set
        {
            _regno = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public float ScienceMarks
    {
        get
        {
            return _scienceMarks;
        }
        set
        {
            _scienceMarks = value;
        }
    }


    public float MathMarks
    {
        get
        {
            return _mathMarks;
        }
        set
        {
            _mathMarks = value;
        }
    }


    public float SocialMarks 
    {
        get
        {
            return _socialMarks;
        }
        set
        {
            _socialMarks = value;
        }
    }


    public float HindiMarks
    {
        get
        {
            return _hindiMarks;
        }
        set
        {
            _hindiMarks = value;
        }
    }

    public float EnglishMarks
    {
        get
        {
            return _englishMarks;
        }
        set
        {
            _englishMarks = value;
        }
    }

    public float ComputerMarks
    {
        get
        {
            return _computerMarks;
        }
        set
        {
            _computerMarks = value;
        }
    }


    public void AcceptDetails()
    {
        System.Console.WriteLine("Please Enter the Details Below :");
        System.Console.WriteLine("Enter the Student  Id: ");
        RegNO = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Student Name: ");
        Name = Console.ReadLine() ?? "";
        System.Console.WriteLine("Enter the Science Marks: ");
        ScienceMarks = Convert.ToSingle(Console.ReadLine());
        System.Console.WriteLine("Enter the Math Marks: ");
        MathMarks = Convert.ToSingle(Console.ReadLine());
        System.Console.WriteLine("Enter the Social Marks: ");
        EnglishMarks = Convert.ToSingle(Console.ReadLine());
        System.Console.WriteLine("Enter the Hindi Marks: ");
        HindiMarks = Convert.ToSingle(Console.ReadLine());
        System.Console.WriteLine("Enter the English Marks: ");
        EnglishMarks = Convert.ToSingle(Console.ReadLine());
        System.Console.WriteLine("Enter the Computer Marks: ");
        ComputerMarks = Convert.ToSingle(Console.ReadLine()); 
    }

    public void calculateMarks()
    {
        total = MathMarks+ScienceMarks+SocialMarks+ComputerMarks+HindiMarks+EnglishMarks;
        average = total/(6f);

        if (average >= 90)
        {
            division = 'A';
        }
        else if (average>=80 && average < 90)
        {
            division = 'B';
        }else if(average >=70 && average < 80)
        {
            division = 'C';
        }else if(average >=60 && average < 70)
        {
            division = 'D';
        }
        else
        {
            division = 'F';
        }
    }

    public void displayDetails()
    {
        System.Console.WriteLine($"welcome {Name}");
        System.Console.WriteLine($"Your id is  {RegNO}");
        System.Console.WriteLine($"Your science marks is  {ScienceMarks}");
        System.Console.WriteLine($"Your math marks is  {MathMarks}");
        System.Console.WriteLine($"Your hindi marks is  {HindiMarks}");
        System.Console.WriteLine($"Your social marks is  {SocialMarks}");
        System.Console.WriteLine($"Your computer marks is  {ComputerMarks}");
        System.Console.WriteLine($"Your english marks is  {EnglishMarks}");

        System.Console.WriteLine($"Your total marks is {total}");
        System.Console.WriteLine($"Your average marks is {average}");
        System.Console.WriteLine($"Your division is {division}");




    }

    
}


/*12) program to read student num,name,mark of six subject in property and 
calculate total and average and print result and division 
program that reads a student’s exam score from the user and determines their grade based on the following grading scale:
•	Score ≥ 90 : Grade A
•	80 ≥ Score < 90 : Grade B
•	70 ≥ Score < 80 : Grade C
•	60 ≥ Score < 70 : Grade D
•	Score < 60 : Grade F

*/