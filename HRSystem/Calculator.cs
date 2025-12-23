class Calculator
{
    public Calculator()
    {
        
    }

    public void Swap1(ref int number1,ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
}