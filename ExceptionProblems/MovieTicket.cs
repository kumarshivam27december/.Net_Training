class MovieTicket
{
    public static void Solve()
    {
        int noOfTicket;
        decimal pricePerTicket;
        try
        {
            noOfTicket = Convert.ToInt32(Console.ReadLine());
            pricePerTicket = Convert.ToDecimal(Console.ReadLine());

            if (noOfTicket <= 0)
            {
                throw new ArgumentException("Error: Number of tickets must be greater than 0.");
            }

            if (pricePerTicket <= 0)
            {
                throw new ArgumentException("Error: Price per ticket must be greater than 0.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        decimal output = noOfTicket * pricePerTicket;
        Console.WriteLine($"Total ticket cost: {output}");

    }
}