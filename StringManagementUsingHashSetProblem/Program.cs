public class Program
{
    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1: Create (Add a new string)");
            Console.WriteLine("2: Read (Display all strings)");
            Console.WriteLine("3: Update (Update an existing string)");
            Console.WriteLine("4: Delete (Remove a string)");
            Console.WriteLine("5: Exit");

            Console.WriteLine("Enter your choice: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Enter the string to add: ");
                    string input = Console.ReadLine() ?? "";
                    StringClass.Create(input);
                    break;
                case 2:
                    StringClass.Read();
                    break;

                case 3:
                    Console.WriteLine("Enter the string to update");
                    string oldStr = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter the new string: ");
                    string newStr = Console.ReadLine() ?? "";
                    StringClass.Update(oldStr, newStr);
                    break;

                case 4:
                    Console.WriteLine("Enter the string to delete");
                    string todelete = Console.ReadLine() ?? "";
                    StringClass.Delete(todelete);
                    break;

                case 5:
                    Console.WriteLine("Exiting....");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}


public class StringClass
{
    static HashSet<string> strings = new HashSet<string>();
    public static void Create(string str)
    {
        if (strings.Contains(str))
        {
            Console.WriteLine($"{str} already exists");
        }
        else
        {
            Console.WriteLine($"'{str}' has been added.");
            strings.Add(str);
        }
    }

    public static void Read()
    {
        Console.WriteLine("Current item in the set: ");
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
    }

    public static void Update(string oldStr, string newStr)
    {
        if (strings.Contains(oldStr))
        {
            strings.Remove(oldStr);
            strings.Add(newStr);
            Console.WriteLine($"{oldStr} has been updated to {newStr}");
        }
        else
        {
            Console.WriteLine($"'{oldStr}' does not exist in the set.");
        }
    }

    public static bool IsPresent(string str)
    {
        if (strings.Contains(str))
        {
            return true;
        }
        return false;
    }

    public static void Delete(string str)
    {
        if (strings.Contains(str))
        {
            Console.WriteLine($"'{str}' has been removed.");
        }
        else
        {
            Console.WriteLine($"'{str}' does not exist in the set.");
        }
    }

}