class House : Property
{
    public House()
    {
        PropertyType = "house";
    }

    protected override double CalculatePropertyTax()
    {
        return Math.Round(0.02*Area,2);
    }
}