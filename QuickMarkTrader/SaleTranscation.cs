
class SaleTranscation
{
    public string  InvoiceNo { get; set; }
    public string  CustomerName { get; set; }
    public string  ItemName { get; set; }
    public int  Quantity { get; set; }
    public decimal  PurchaseAmount { get; set; }
    public decimal  SellingAmount { get; set; }


    public string  ProfitOrLossStatus { get; set; }

    public decimal  ProfitOrLossAmount { get; set; }
    public decimal  ProfitMarginPercent { get; set; }


    public SaleTranscation(string InvoiceNo,string CustomerName,string ItemName,int Quantity,decimal PurchaseAmount,decimal SellingAmount)
    {
        this.InvoiceNo = InvoiceNo;
        this.CustomerName = CustomerName;
        this.ItemName = ItemName;
        this.Quantity = Quantity;
        this.PurchaseAmount = PurchaseAmount;
        this.SellingAmount = SellingAmount;
    }

    public void calculateProfitOrLoss()
    {
        if (PurchaseAmount > SellingAmount)
        {
            ProfitOrLossStatus = "LOSS";
            ProfitOrLossAmount = PurchaseAmount - SellingAmount;
            ProfitMarginPercent = 0.0m;
        }else if(SellingAmount > PurchaseAmount)
        {
            ProfitOrLossStatus = "Profit";
            ProfitOrLossAmount = SellingAmount - PurchaseAmount;
            ProfitMarginPercent = ProfitOrLossAmount/PurchaseAmount*100;
        }
        else
        {
            ProfitOrLossStatus = "BREAK-EVEN";
            ProfitOrLossAmount = 0;
            ProfitMarginPercent = 0.0m;
        }
    }

    public string calculateProfitStatus()
    {
        return ProfitOrLossStatus;
    }

    public decimal calculateProfitAmount()
    {
        return SellingAmount-PurchaseAmount;
    }

    public decimal calculateProfitMargin()
    {
        return ((SellingAmount-PurchaseAmount)/PurchaseAmount)*100;
    }
    public void View()
    {
        Console.WriteLine("-------------Last Transaction------------");
        Console.WriteLine($"InvoiceNo: {InvoiceNo}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Quantity: {Quantity:F2}");
        Console.WriteLine($"Purchase Amount: {PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {SellingAmount:F2}");
        Console.WriteLine($"Status: {ProfitOrLossStatus:F2}");
        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent:F2}");
    }


    public void Recompute()
    {
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Quantity: {Quantity:F2}");
        Console.WriteLine($"Purchase Amount: {PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {SellingAmount:F2}");
        Console.WriteLine($"Status: {ProfitOrLossStatus:F2}");
        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent:F2}");
    
    }

  

    
}