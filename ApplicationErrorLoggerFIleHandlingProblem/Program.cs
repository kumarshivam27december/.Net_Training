using System.IO;
public class Program
{
    //constant file name
    private const string FileName = "error_log.txt";
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1.log error");
            Console.WriteLine("2.view error");
            Console.WriteLine("3.clear error");
            Console.WriteLine("4.exit");
            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    LogError();
                    break;
                case "2":
                    ViewError();
                    break;
                case "3":
                    ClearLog();
                    break;
                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;  
            }
        }
    }

    static void LogError()
    {
        try
        {
            Console.WriteLine("Enter error message");
            string message = Console.ReadLine() ?? "";
            string logEntry = DateTime.Now.ToString("dd/MM/yyyy")+" : "+message;
            File.AppendAllText(FileName,logEntry+Environment.NewLine);
            Console.WriteLine("Error logged Successfully");
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to log error");
        }
    }

    static void ViewError()
    {
        try
        {
            if (!File.Exists(FileName))
            {
                Console.WriteLine("No error Logged.");
                return;
            }

            string content = File.ReadAllText(FileName);
            if (string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("No error logged.");
            }
            else
            {
                Console.WriteLine("\n"+content);
            }
        }
        catch (Exception)
        {
          Console.WriteLine("Unable to read error log.");
        }
    }

    static void ClearLog()
    {
        try
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
                Console.WriteLine("Log successfully cleared");
            }
            else
            {
                Console.WriteLine("No error logged.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Unable to clear the log");
        }
    }
}