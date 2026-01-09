class ArrayAddition
{
    public static void Solve()
    {
        string inputArray1;
        string inputArray2;

        try
        {
            inputArray1 = Console.ReadLine() ?? "";
            inputArray2 = Console.ReadLine() ?? "";
            string[] inputArr1 = inputArray1.Split(" ");
            string[] inputArr2 = inputArray2.Split(" ");
            int inputArrLength1 = inputArr1.Length;
            int inputArrLength2 = inputArr2.Length;

            int[] numbers1 = new int[inputArrLength1];
            int[] numbers2 = new int[inputArrLength2];
            if (inputArrLength1 != inputArrLength2)
            {
                throw new InvalidOperationException("Invalid Length not matched");
            }
            int index = 0;
            foreach (var item in inputArr1)
            {
                numbers1[index++] = Convert.ToInt32(item);
            }

            index = 0;

            foreach (var item in inputArr2)
            {
                numbers2[index++] = Convert.ToInt32(item);
            }

            int[] sumArray = new int[inputArrLength1];
            for (int i = 0; i < inputArrLength1; i++)
            {
                sumArray[i] = numbers1[i]+numbers2[i];
            }
            int userIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{sumArray[userIndex]}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: Invalid input format. Please enter integers only.");
            Console.WriteLine($"Exception Message: Input string was not in a correct format");
            return;
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range for the sum array.");
            Console.WriteLine($"Index was outside the bounds of the array");
            return;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Arrays must have the same length for addition.");
            return;
        }
        
    }
}