class Program //Subscriber
{

   
    public static void Main(string[] args)
    {
        
        AddTwoNumber a = new AddTwoNumber();
        a.ev_OddNumber += new AddTwoNumber.dg_OddNumber(EventMessage);
        a.Add();

        // FuncDeligateDemo.Solve();
        // ActionDeligateDemo.Solve();
        PredicateDeligateDemo.Solve();
        
       
    }

    //delegate calls this method when event raised

    static void EventMessage()
    {
        Console.WriteLine("************ Event Executed : This is Odd Number*************");
    }
}

