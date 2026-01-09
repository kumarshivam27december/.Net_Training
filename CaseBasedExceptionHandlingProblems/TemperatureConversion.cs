class TemperatureConversion
{
    public static void Solve()
    {
        double temperature;
        string temperatureType;
        try
        {
            temperature = Convert.ToDouble(Console.ReadLine());
            temperatureType = Console.ReadLine();
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Invalid format ");
            Console.WriteLine("Input string was not in correct format");
            return;
        }

        double output;
        string types;
        if (temperatureType =="F")
        {
            output = (temperature - 32)*5/9;
            types = "Celcius";
        }else if(temperatureType == "C")
        {
            output = (temperature*9 /5 )+32;
            types = "Fahrenheit";
        }
        else
        {
            Console.WriteLine("Invalid Conversion type. Please Enter F or C");
            return;
        }

        Console.WriteLine($"Temperature in {types} value : {output}");
    }
}