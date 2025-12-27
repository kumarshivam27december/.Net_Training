using System;
class Program
{
    public static void Main(string[] args)
    {
        IPayment payment ;
        payment = new CreditCardPayment();
        payment.Pay(100.0);
        payment.Refund(10.0);
        
        IPayment payment1 ;
        payment1 = new UpiPayment();
        payment1.Pay(100.69);
        payment1.Refund(69.00);
    }
    
}
