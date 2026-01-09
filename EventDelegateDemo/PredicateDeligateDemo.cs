class PredicateDeligateDemo
{
    public static void Solve()
    {
        Predicate<string> CheckIfApple = IsApple;
        bool result = IsApple("I Phone X");
        if (result)
        {
            Console.WriteLine("It is an iphone");
        }
    }

    private static bool IsApple(string modelName)
    {
        if(modelName=="I Phone X")
        {
            return true;
        }
        return false;
    }
}