using System;
class StaticInstanceDemo
{
    public int var =0;//instance variable
    public static int var1 = 10;// static variable 
    public void InstanceCount() //instance method
    {
        var++;
    }
    public static void StaticCount() //static method    
    {
        var1++;
    }
    public int InstanceDisplay() //instance method
    {
        return var;
    }
    public static int StaticDisplay() //static method
    {
        return var1;
    }

}