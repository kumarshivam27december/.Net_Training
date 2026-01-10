class InvalidQuantityException : SystemException
{
    public InvalidQuantityException(string message)
    {
        Console.WriteLine($"{message}"); 
    }

    public InvalidQuantityException()
    {
        Console.WriteLine("Error: Quantity must be greater than zero.");
    }
}