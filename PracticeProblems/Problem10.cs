class Problem10
{
    public static void Solve()
    {
        int number1;
        int number2;
        int number3;

        System.Console.WriteLine("Enter input 1 : ");
        number1 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter input 2 : ");
        number2 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter input 3 : ");
        number3 = Convert.ToInt32(System.Console.ReadLine());


        if (number1 > number2)
        {
            if (number2 > number3 || number2==number3)
            {
                System.Console.WriteLine("number 1 is largest");
            }else if (number2 < number3)
            {
                if (number1 > number3)
                {
                    System.Console.WriteLine("number 1 is largest");
                }
                else
                {
                    System.Console.WriteLine("number 3 is largest");
                }
            }
        }
        else
        {
            if(number1 > number3 || number1 == number3)
            {
                System.Console.WriteLine("number 2 is largest");
            }else if(number1 < number3)
            {
                if(number2 > number3)
                {
                    System.Console.WriteLine("number 2 is largest");
                }
                else
                {
                    System.Console.WriteLine("number 3 is largest");
                }
                
            }
        }

    }
}