using System;
class Vehicle
{
    protected double distance = 0.0;
    protected double hour = 0.0;
    protected double fuel = 0.0;
    public Vehicle(double distance,double hour,double feul)
    {
        this.distance = distance;
        this.hour = hour;
        this.fuel = feul;

    }
    public void Average()
    {
        double average = 0.0;
        average = distance/fuel;
        Console.WriteLine("vehicle average is {0:0.0}",average);
    }
    public virtual void Speed()
    {
        double speed = 0.0; 
        speed = distance/hour;
        Console.WriteLine("speed of the vehical is {0:0.0}/kmp",speed);
    }
}