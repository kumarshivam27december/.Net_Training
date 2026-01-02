abstract class Property
{
    public int PropertyId { get; set; }
    public string Location { get; set; }

    public double Area { get; set; }
    public string PropertyType { get; set; }

    protected abstract double CalculatePropertyTax();

    public double GetPropertyTax()
    {
        return CalculatePropertyTax();
    }
}