using System.IO;
public class Program
{
    private const string FilePath = "attendance.txt";
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1.Add attendence");
            Console.WriteLine("2.view attendence log");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    AddAttendance();
                    break;
                case "2":
                    ViewAttendence();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        }
    }
    static void AddAttendance()
    {
        try
        {
            Console.WriteLine("Enter student id");
            string studentId = Console.ReadLine() ?? "";
            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine() ?? "";
            Console.WriteLine("Enter status (present/absent)");
            string status = Console.ReadLine() ?? "";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string record = $"{date} | {studentId} | {studentName} | {status}";

            using (StreamWriter streamWriter = new StreamWriter(FilePath, true))
            {
                streamWriter.WriteLine(record);
            }
            Console.WriteLine("Attendance record");
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while writing to the file."); 
        }
    }
    static void ViewAttendence()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("No attendance record was found");
                return;
            }
            using (StreamReader streamReader = new StreamReader(FilePath))
            {
                string content = streamReader.ReadToEnd();
                if (string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine("No attendance records found.");
                }
                else
                {
                    Console.WriteLine("----Attendence logs----");
                    Console.WriteLine(content);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while reading the file.");
        }
    }
}