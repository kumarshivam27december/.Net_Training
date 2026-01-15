public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the flavour");
        string flavour = Console.ReadLine() ?? "";
        Console.WriteLine("Enter the quantity");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price per unit");
        int pricePerUnit = Convert.ToInt32(Console.ReadLine());
        Chocolate chocolate = new Chocolate();
        chocolate.Flavour = flavour;
        chocolate.Quantity = quantity;
        chocolate.PricePerUnit = pricePerUnit;
        if (chocolate.ValidateChocolateFlavour())
        {
            Console.WriteLine("Flavour : "+chocolate.Flavour);
            Console.WriteLine("Quantity : "+chocolate.Quantity);
            Console.WriteLine("Price Per Unit: "+chocolate.PricePerUnit);
            chocolate.CalculateDiscountedPrice();
            Console.WriteLine("Total Price: "+chocolate.TotalPrice);
            Console.WriteLine("Discounted Price: "+chocolate.DiscountedPrice);
        }
        else
        {
            Console.WriteLine("Invalid Flavour");
        }
    }
}

class Chocolate
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }

    public int PricePerUnit { get; set; }
    public double TotalPrice { get; set; }

    public double DiscountedPrice { get; set; }

    public bool ValidateChocolateFlavour()
    {
        if(Flavour == "Dark" || Flavour=="Milk" || Flavour == "White")
        {
            return true;
        }
        return false;
    }

    public void CalculateDiscountedPrice()
    {
        double DiscountPercent = 0;
        if (Flavour == "Dark")
        {
            DiscountPercent =18;
        }else if(Flavour == "White")
        {
            DiscountPercent = 6;
        }
        else
        {
            DiscountPercent = 12;
        }

        TotalPrice = Quantity*PricePerUnit;
        DiscountedPrice = TotalPrice - (TotalPrice*DiscountPercent/100);

    }
}

