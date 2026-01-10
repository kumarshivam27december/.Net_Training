class PriceQuantity
{
    public static void Demo()
    {
        try
        {
            decimal price = Convert.ToDecimal(Console.ReadLine());
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (price <= 0)
            {
                throw new InvalidPriceException();
            }
            if(quantity <= 0)
            {
                throw new InvalidQuantityException();
            }
            decimal totalCost = price*quantity;
            Console.WriteLine($"Total cost is {totalCost}");
        }
        catch (InvalidPriceException)
        {

        }
        catch (InvalidQuantityException)
        {
            
        }catch(FormatException )
        {
            Console.WriteLine("Error: Please enter a valid number");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Please enter a valid number");
        }
    }
}