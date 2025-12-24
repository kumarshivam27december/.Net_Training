using System;
class Car: Vehicle  //created a child class Car from base class vehicle 
{
    public Car(double distance,double hour,double feul) : base(distance,hour,feul)
    {
        
    }
    public new void Average()
    {
        double average = 0.0;
        average = distance/fuel;
        Console.WriteLine("Average of the car is {0:0.0}",average);
    }
    public override void Speed()
    {
        double speed = 0.0;
        speed = distance/hour;
        Console.WriteLine("Speed of the car is {0:0.0}",speed);
    }
}