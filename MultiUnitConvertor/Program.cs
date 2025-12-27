using System;
class Program
{
    public static void Main(string[] args)
    {
        UnitConvertor converter = new UnitConvertor();

        double value;
        string fromUnit;
        string toUnit;
        Console.WriteLine("enter the value");
        value = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter from unit ");
        fromUnit = Console.ReadLine() ?? "";
        Console.WriteLine("enter to unit");
        toUnit = Console.ReadLine() ?? "";
        double output;
        if(toUnit!=""){
            output = converter.Convert(value,fromUnit,toUnit);
            Console.WriteLine($"{fromUnit} to {toUnit} is {output}");
        }
        else
        {
            output = converter.Convert(value,fromUnit);
            Console.WriteLine($"{fromUnit}  to default unit is {output}");
        }

    }
}

