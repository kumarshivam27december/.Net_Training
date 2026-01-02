using System.Net.Sockets;

class Apartment : Property
{
    public Apartment()
    {
        PropertyType = "apartment";
    }

    protected override double CalculatePropertyTax()
    {
        return  Math.Round(Area*0.01,2);
    }
}