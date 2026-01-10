using System.Collections;

class NumberList
{
    private static ArrayList numArrayList = new ArrayList();
    private static void AddNumber(int number)
    {
        numArrayList.Add(number);
        Console.WriteLine($"{number} added to the number list");
    }

    private static void RemoveNumber(int number)
    {
        if (numArrayList.Contains(number))
        {
            numArrayList.Remove(number);
            Console.WriteLine($"{number} removed from the number list");
        }
        else
        {
            Console.WriteLine($"{number} is not found in array list");
        }
    }
    private static void DisplayNumbers()
    {
        Console.WriteLine("Current numbers in the list: ");
        foreach (var item in numArrayList)
        {
            Console.WriteLine(item);
        }
    }

    public static void Demo()
    {
        string input;
        while (true)
        {
            input = Console.ReadLine() ?? "";
            if (input == "exit")
            {
                break;
            }
            if (input == "add")
            {
                int numberToAdd = 0;
                try
                {
                    numberToAdd = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                NumberList.AddNumber(numberToAdd);
            }else if (input == "remove")
            {
                int numbertoremove = 0;
                try
                {
                    numbertoremove = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.Please enter a valid number.");
                }
                NumberList.RemoveNumber(numbertoremove);
            }else if(input == "display")
            {
                NumberList.DisplayNumbers();
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}