using System.Reflection.Metadata.Ecma335;

public delegate void Print(int val, string str);
public delegate void Print1(int val);

public delegate bool IsTeenager(Student student);

public delegate int AddDel(int num1, int num2);
class Program
{
    public static void PrintHelperMethod(Print1 printDel, int val)
    {
        val += 10;
        printDel(val);
    }
    public static void Main(string[] args)
    {

        IsTeenager isTeenager = delegate (Student s)
        {
            return s.age>12 && s.age<20; 
        };


        IsTeenager isTeenager1 = (s) =>
        {
            return s.age>12 && s.age<20;
        };

        IsTeenager isTeenager2 = s => s.age>12 && s.age<20;

        Student student = new Student
        {
            Id = 1,
            Name = "Shivam",
            age = 18
        };

        if (isTeenager2(student))
        {
            Console.WriteLine();
            Console.WriteLine("it is teenager");
        }
        else
        {
            Console.WriteLine("it is not teenager");
        }

        //-----------------
        // AddDel addnum = delegate (int num1, int num2)
        // {
        //     return num1 + num2;
        // };

        AddDel addnum = (int num1,int num2) => {return num1+num2;};
        int sum = addnum(30, 20);
        Console.WriteLine($"the sum is {sum}");

        var newsume = (int num1, int num2) => num1 + num2;


        //printhelpermethod 
        //passing anonymous with 2 parameter
        PrintHelperMethod(delegate (int val)
        {
            Console.WriteLine($"This is anonymous method and value is {val}");
        }, 100);
        Print print = delegate (int val, string str)
        {
            Console.WriteLine($"hello world {val} {str}");
        };
        Console.WriteLine();
        print(100, "welcome");
        var ManagerInfo = new
        {
            id = 101,
            Name = "Rajesh Patel"
        };
        Console.WriteLine();
        Console.WriteLine($"manager id is {ManagerInfo.id}");
        Console.WriteLine($"manager name is {ManagerInfo.Name}");
        // ManagerInfo.id=102;
        // ManagerInfo.Name="Shivam" //both of this is gonna give error
        // MyMethod(ManagerInfo);
    }
    public static void MyMethod(dynamic dy)
    {
        Console.WriteLine(dy);
        Console.WriteLine(dy);
    }
}