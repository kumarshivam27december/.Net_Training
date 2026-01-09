class Program
{
    public static void Main(string[] args)
    {
        /*
        Employee employee = new Employee();
        employee[0] = "String 0";
        employee[1] = "String 1";
        employee[2] = "String 2";
        employee[3] = "String 3";
        employee[4] = "String 4";
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(employee[i]);
        }
        Console.WriteLine("Value at third index is {0}",employee[3]);
        Console.WriteLine("value String 4 is at index {0}",employee["String 4"]);
        */
        // ExceptionDemo.Demo();
        
        try
        {
            throw new MyException("Rajesh");
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception caught here "+ e.ToString());
        }
        Console.WriteLine("Last Statement");
    }
}