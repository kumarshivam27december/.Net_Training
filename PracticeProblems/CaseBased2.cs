class CaseBased2
{
    public static void Solve()
    {
        float celcius;
        System.Console.WriteLine("Enter temperature in celcius");
        celcius = Convert.ToSingle(System.Console.ReadLine());

        System.Console.WriteLine($"Temperature in celcius is {celcius}");


        float Fahrenheit;
        Fahrenheit = (celcius*9/5)+32;

        System.Console.WriteLine($"Temperature in Fahrenheit is {Fahrenheit}");


    }
}