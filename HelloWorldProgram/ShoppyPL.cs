using System;
using MyRetailLogic;
class DiscountPrice
{
    public static void Calculate()
    {
        int costPrice1;
        int costPrice2;

        //taking user input
        Console.Write("Enter Price For Item1 : ");
        costPrice1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Price For Item2 : ");
        costPrice2 = Int32.Parse(Console.ReadLine());

        //business logic
        int total = costPrice1 + costPrice2;
        RetailLogic r1Obj = new RetailLogic();//named object 
        int discount = r1Obj.CalcDiscount(total);
        int actualPayablePrice = total - discount;

        //UI
        Console.WriteLine("LPU SHOPPING");
        Console.WriteLine("Price of Product 1 {0}", costPrice1);
        Console.WriteLine("Price of Product 2 {0}", costPrice2);
        Console.WriteLine("Total Price {0}", total);
        Console.WriteLine("Discounted Price of Products {0}", discount);
        Console.WriteLine("Actual Payable Price after Discount is {0}", actualPayablePrice);
    }
}