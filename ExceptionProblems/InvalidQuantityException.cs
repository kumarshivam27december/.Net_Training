class InvalidQuantityException : SystemException
{
    public InvalidQuantityException(string str)
    {
        Console.WriteLine($"custom invalid {str}");
    }

    public InvalidQuantityException()
    {
        Console.WriteLine("default constructor invalid quantity");
    }
}