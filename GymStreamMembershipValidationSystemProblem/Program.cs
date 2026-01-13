using System.Diagnostics;

class InvalidTierException : SystemException
{
    public InvalidTierException(string message)
    {
        Console.WriteLine($"{message}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Membership membership;
        try
        {
            Console.WriteLine("Enter Tier");
            string tier = Console.ReadLine() ?? "";
            Console.WriteLine("Enter duration in Month");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price ");
            double price = Convert.ToDouble(Console.ReadLine());
            membership = new Membership
            {
              Tier = tier,
              DurationInMonth = duration,
              BasePricePerMonth = price  
            };
            membership.ValidateEnrollment();

        }
        catch (InvalidTierException)
        {
            return;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Format");
            return;
        }
        catch (Exception)
        {
            Console.WriteLine("Other Exception");
            return;
        }
        double totalBill = membership.CalculateTotalBill();
        Console.WriteLine($"total bill is {totalBill}");
    }
}
public class Membership
{
    public string  Tier { get; set; }
    public int DurationInMonth { get; set; }

    public double BasePricePerMonth { get; set; }

    public bool ValidateEnrollment()
    {
        Tier = Tier.ToLower();
        if(Tier=="basic" || Tier=="premium" || Tier == "elite")
        {
            if (DurationInMonth <= 0)
            {
                throw new Exception("Error: Duration must be at least one month.");
            }
            else
            {
                return true;
            }
        }
        else
        {
            throw new InvalidTierException("Error: Tier not recognized.");
        }
    }

    public double CalculateTotalBill()
    {
        Tier=Tier.ToLower();
        double total = DurationInMonth*BasePricePerMonth;
        double discount = 0;
        if (Tier == "basic")
        {
            discount = 0.02;
        }else if(Tier== "premium")
        {
            discount = 0.07;
        }
        else
        {
            discount = 0.12;
        }
        double output =  total - (total*discount);
        return output;
    }

}