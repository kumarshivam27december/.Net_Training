class Circle : Shape
{

    public double Radius { get; set; }
    public Circle(double Radius)
    {
        this.Radius = Radius;
    }
    public override double CalculateArea()
    {
        return (Math.PI)*Radius*Radius;
    }
    
}