class InvalidPriceException : SystemException
{
    public InvalidPriceException(string str)
    {
        Console.WriteLine($"custom message is {str}");
    }

    public InvalidPriceException()
    {
        Console.WriteLine("default constructor is called");
    }
}