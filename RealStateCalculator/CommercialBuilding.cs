class CommercialBuilding : Property
{

    public CommercialBuilding()
    {
       PropertyType = "commercialbuilding";
    }

    protected override double CalculatePropertyTax()
    {
        return Math.Round(0.03*Area,2);
    }
}