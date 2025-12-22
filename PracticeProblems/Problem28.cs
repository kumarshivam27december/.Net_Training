class Problem28
{
    public static void Solve()
    {
        string inputString;
        do
        {
            int studentNo;
            System.Console.WriteLine("Enter student roll no : ");
            studentNo = Convert.ToInt32(System.Console.ReadLine());
            string studentName;
            System.Console.WriteLine("Enter student name : ");
            studentName = System.Console.ReadLine() ?? "";
            int marks;
            System.Console.WriteLine("Enter student marks: ");
            marks = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter y to exit or any else to continue");
            inputString = System.Console.ReadLine() ?? "";
            inputString = inputString.ToLower();
        }while(inputString!="y");
    }
    
}