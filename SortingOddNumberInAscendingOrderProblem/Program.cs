using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine() ?? "" ;
        string[] inputArr = input.Split(" ");
        
        List<int>newList1 =  ParseIntegers(inputArr);
        List<int>newList2 = GetOddNumbers(newList1);

        newList2.Sort();

        foreach (var item in newList2)
        {
            Console.Write($"{item} ");
        }

    }



    private static List<int> ParseIntegers(string[] inputArr)
    {
        List<int> numbers = new List<int>();
        
        foreach (var item in inputArr)
        {
            try
            {
                int num = Convert.ToInt32(item);
                numbers.Add(num);
            }
            catch (FormatException)
            {
                
            }
        }
        return numbers;
    }

    private static List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> newList = new List<int>();
        foreach (var item in numbers)
        {
            if (item % 2 != 0)
            {
                newList.Add(item);
            }
        }
        return newList;
    }
}