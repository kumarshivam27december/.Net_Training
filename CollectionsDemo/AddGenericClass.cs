using System;

class  AddGenericClass<T>
{
    T n1;
    T n2;
    
    T result;

    //generic default constructor
    public  AddGenericClass()
    {
        
    }

    // Generic constructor (parametirized)
    public AddGenericClass(T n1, T n2)
    {
        this.n1 = n1;
        this.n2 = n2;
    }

    public T AddAllType(T num1,T num2)
    {
        // n1 = num1
        // n2 = num2
        //it will give compile time error when adding as it dont know what type it is at compile time
        dynamic x = num1;
        dynamic y = num2;
        result = x+y;
        return result;
    }
}