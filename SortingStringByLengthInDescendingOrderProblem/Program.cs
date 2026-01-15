public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(" ");
        inputArr.Sort((x,y) => y.Length.CompareTo(x.Length));
        foreach (string item in inputArr)
        {
            Console.Write($" {item}");
        }
    }
}