class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double Length,double Width)
    {
        this.Length = Length;
        this.Width = Width;
    }
    public override double CalculateArea()
    {
        return Length*Width;
    }
}