using System.Collections;
class WithGenericDemo
{
    public static void Demo()
    {
        
        Console.WriteLine("With Generic Class");

        Console.WriteLine();
        Console.WriteLine();

        AddGenericClass<int> addInteger = new AddGenericClass<int>();
        int sum  = addInteger.AddAllType(59,10);
        Console.WriteLine($"Sum of Integer is {sum}");

        AddGenericClass<float> addFloat = new AddGenericClass<float>();
        float sum1 = addFloat.AddAllType(58.1f,10.9f);
        Console.WriteLine($"Sum of Float is {sum1}");

        AddGenericClass<string> addString = new AddGenericClass<string>();
        string sum2 = addString.AddAllType("sixty","Nine");
        Console.WriteLine($"sum of String is {sum2}");
    }
}