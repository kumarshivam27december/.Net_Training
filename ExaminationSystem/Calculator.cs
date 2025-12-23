using System;
class Calculator
{
    public Calculator()
    {
        
    }

    public void Addition(int number1,int number2,out int result,out int marks1,out int marks2)
    {
        result = number1+number2;
        marks1 = number1;
        marks2 = number2;
    }
}