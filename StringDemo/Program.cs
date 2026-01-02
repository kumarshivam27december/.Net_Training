using System;
class Program
{
    public static void Main(string[] args)
    {
        //from string literal and string concatenation
        string fname,lname;
        fname = "Rowan";
        lname = "Atkinson";

        char[] letter = {'h','e','l','l','o'};
        string[] sarray = {"Hello","From","Tutorial","Point"};

        string fullName = fname+lname;
        Console.WriteLine("Full Name: {0}",fullName);


        //by using Constructor {'h','e','l','l','o'};
        string greeting = new string(letter);
        Console.WriteLine("Greeting: {0}",greeting);

        //method returing string {"Hello","From","capgemini","world"};
        string message = String.Join(" ",sarray);
        Console.WriteLine("Message: {0}",message);

        //formatting method to convert a value

        DateTime waiting = new DateTime(2025,10,10,17,30,1);
        string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
        Console.WriteLine("Message: "+chat);


        string str1 = "This is test1";
        string str2 = "This is text1";

        if (String.Compare(str1, str2)==0)
        {
            Console.WriteLine(str1 + " and "+str2+ " are equal");
        }
        else
        {
            Console.WriteLine(str1+" and "+str2+ " are not equal");
        }


        string str = "This is test";
        if (str.Contains("test"))
        {
            Console.WriteLine("The sequence 'test' was found");
        }


        string str3 = "Last night i dreamt of san pedro";
        Console.WriteLine(str3);
        string substr = str3.Substring(23);
        Console.WriteLine(substr);


        //1. this will print world in next line
        Console.WriteLine("Hello \n World");
        Console.WriteLine("\"Hello world\"");


        Console.WriteLine("D:\\Projects\\csharp\\Program.cs");
        Console.WriteLine(@"D:\Projects\csharp\Program.cs");



        string str4 = @"
                Hello Alice

                   Good Morning!
                Your files have been saved to this location.
                \shared\alice  "" hello world ""

        Thanks.";

        Console.WriteLine(str4);



        var name = "Alice";
        var greeting1 = String.Format("Hello {0}, {1}",name,"good morning");
        Console.WriteLine(greeting1);

        var name2 = "Alice";
        var greet = "good morning";
        var greeting2 = $"Hello {name2}, {greet}";
        Console.WriteLine(greeting2);


        var num = 12;
        Console.WriteLine($"The square of the {num} is {num*num}");

        var text = "Hello world";
        var sub_text = text.Substring(6,5);
        Console.WriteLine(sub_text);

        var text3 = "Hello world";
        Console.WriteLine(text3.ToUpper());
        Console.WriteLine(text3);

        var text4 = "Hello world";
        Console.WriteLine(text4.ToUpper());
        Console.WriteLine(text4);

        var text5 = " hello world    ";
        Console.WriteLine(text5.Trim());

        var csv = "Alice,Bob,Chris,Dave,Eric,Fred";
        string[] names = csv.Split(",");

        for(var i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        var greet5 = "hello alice. welcome";
        var index = greet5.IndexOf("el");
        Console.WriteLine(index);

        var greet6 = "hello alice. welcome";
        var index1 = greet6.LastIndexOf("el");
        Console.WriteLine(index1);

    }
}