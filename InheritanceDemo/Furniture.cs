using System;
public abstract class Furniture
{
    protected int num;
    protected string color = "";
    protected int width;

    protected int height;

    public abstract void Accept();
    public abstract void Display();

    public virtual void MyMethod()
    {
        Console.WriteLine("My Method");
    } //can have both abstract method as well as concrete method


}