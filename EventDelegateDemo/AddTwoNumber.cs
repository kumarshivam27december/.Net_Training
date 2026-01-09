class AddTwoNumber
{
    public delegate void dg_OddNumber();// declared delegate
    public event dg_OddNumber ev_OddNumber; // declared events
    public void Add()
    {
        int result;
        result = 5+4;
        Console.WriteLine(result.ToString());

        //check if result is odd number then raise event
        if((result %2!=0 ) && (ev_OddNumber != null))
        {
            ev_OddNumber(); //reaised event
        }

    }
}