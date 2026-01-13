public class Program
{
    public static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Enter the Account number");
            string AccountNo = Console.ReadLine() ?? "";
            Console.WriteLine("Enter the Initial Account");
            decimal InitialBalance = Convert.ToDecimal(Console.ReadLine());
            Account account = new Account
            {
                AccountNumber = AccountNo,
                Balance = InitialBalance
            };
            Console.WriteLine("1.Withdrawal");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("Enter Choice");
            string choice = Console.ReadLine() ?? "";
            if (choice == "1")
            {
                Console.WriteLine("Enter amount to withdraw");
                decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                decimal newAmount = account.WithDraw(withdrawalAmount);
                Console.WriteLine("updated Amount after withdrawal is : "+newAmount);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter amount to deposit");
                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                decimal newAmount = account.WithDraw(depositAmount);
                Console.WriteLine("updated Amount after deposit is : "+newAmount);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }catch(FormatException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }catch(Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}

public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public decimal Deposit(decimal Amount)
    {
        if (Amount >= 0)
        {
            Balance += Amount;
        }
        else
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        return Balance;
    }


    public decimal WithDraw(decimal Amount)
    {
        if (Amount > 0 && Amount < Balance)
        {
            Balance -= Amount;
        }
        else if (Amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        else if (Amount > Balance)
        {
            throw new InvalidOperationException("Insufficient Fund");
        }
        return Balance;
    }

}