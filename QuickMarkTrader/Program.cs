using System;

class Program
{
    static SaleTranscation saleTranscation;
    static bool HasLastTranscation = false; 
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("===========QuickMart Traders================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Enter invoice no: ");
                    string InvoiceNo = Console.ReadLine();
                    if (InvoiceNo == "")
                    {
                        Console.WriteLine("Invalid Invoice No");
                        break;
                    }
                    Console.WriteLine("Enter customer name");
                    string CustomerName = Console.ReadLine();
                    Console.WriteLine("Enter Item name");
                    string ItemName = Console.ReadLine();
                    Console.WriteLine("Enter Quantity");
                    int Quantity = Convert.ToInt32(Console.ReadLine());
                    if (Quantity <= 0)
                    {
                        Console.WriteLine("Invalid Quantity");
                        break;
                    }
                    
                    Console.WriteLine("Enter purchase amount(total): ");
                    decimal PurchaseAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter Selling amount(total): ");
                    decimal SellingAmount = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine();

                    saleTranscation = new SaleTranscation(InvoiceNo,CustomerName,ItemName,Quantity,PurchaseAmount,SellingAmount);
                    Console.WriteLine("Transaction saved Successfully");


                    HasLastTranscation = true;

                    saleTranscation.ProfitOrLossStatus = saleTranscation.calculateProfitStatus();
                    saleTranscation.ProfitOrLossAmount = saleTranscation.calculateProfitAmount();
                    saleTranscation.ProfitMarginPercent = saleTranscation.calculateProfitMargin();

                    Console.WriteLine($"Status {saleTranscation.ProfitOrLossStatus}");
                    Console.WriteLine($"Profit/Loss Amount: {saleTranscation.ProfitOrLossAmount:F2}");
                    Console.WriteLine($"Profit Margin (%) : {saleTranscation.ProfitMarginPercent:F2}");
                    Console.WriteLine("--------------------------------------------------");
                    break;

                case 2:
                    if (HasLastTranscation == true)
                    {
                        saleTranscation.View();
                    }
                    else
                    {
                        Console.WriteLine("No last transaction found");
                    }
                    break;
                case 3:
                    saleTranscation.Recompute();
                    saleTranscation.View();
                    break;
                case 4:
                    Console.WriteLine("Thank You");
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}