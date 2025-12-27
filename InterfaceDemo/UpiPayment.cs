using System;
class UpiPayment : IPayment
{
    public void Pay(double amount)
    {
      Console.WriteLine($"paid rs {amount} using UPI");  
    }

    public void Refund(double amount)
    {
        Console.WriteLine($"refunded rs {amount} to UPI.");
    }
}


