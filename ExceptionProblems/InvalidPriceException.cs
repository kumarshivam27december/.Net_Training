class InvalidPriceException : SystemException 
{
    public InvalidPriceException(string message)
    {
        Console.WriteLine($"{message}");
    }

    public InvalidPriceException()
    {
        Console.WriteLine("Error: Price must be greater than zero");
    }
}