public class Program
{
    public static void Main(string[] args)
    {
        string input;
        input = Console.ReadLine() ?? "";
        string[] inputArr = input.Split(" ");

        int[] numbers = new int[inputArr.Length];
        int index = 0;
        foreach (var item in inputArr)
        {
            int temp = Convert.ToInt32(item);
            numbers[index++] = temp;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i]*numbers[i];
        }

        numbers.Sort();

        foreach (var item in numbers)
        {
            Console.Write($" {item}");
        }

    }
}