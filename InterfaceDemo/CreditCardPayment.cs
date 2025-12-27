using System;
class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
      Console.WriteLine($"paid rs {amount} using credit card");  
    }

    public void Refund(double amount)
    {
        Console.WriteLine($"refunded rs {amount} to credit card.");
    }
}


