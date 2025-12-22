class Problem5
{
    public static void Solve()
    {
      int number1;
      int number2;
      System.Console.WriteLine("All Arthimetic operations");
      System.Console.Write("Please Enter number 1 : ");
      number1 = Convert.ToInt32(System.Console.ReadLine());
      System.Console.Write("Please Enter number 2 : ");
      number2 = Convert.ToInt32(System.Console.ReadLine());


      int Addition = number1+number2;
      int Substraction = number1 - number2;;
      int Multiplication =  number1 * number2;
      int Division = number1 / number2;
      int Remainder = number1 % number2;
      System.Console.WriteLine($"Addition of {number1} and {number2} is {Addition}");
      System.Console.WriteLine($"Subtraction of {number1} and {number2} is {Substraction}");
      System.Console.WriteLine($"Multiplication of {number1} and {number2} is {Multiplication}");
      System.Console.WriteLine($"Division of {number1} and {number2} is {Division}");
      System.Console.WriteLine($"Remainder of {number1} and {number2} is {Remainder}");



    }
}