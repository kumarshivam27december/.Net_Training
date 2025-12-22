using System;
namespace  MyRetailLogic
{
    public class RetailLogic
    {
        public int CalcDiscount(int amount)
        {
            int discount = amount*15/100;
            return discount;
        }
    }
    
}