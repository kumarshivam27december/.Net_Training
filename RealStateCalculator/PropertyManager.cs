using System.Formats.Tar;

class PropertyManager
{
      public void PrintPropertyTax(Property property)
    {
      Console.WriteLine($"Property Tax for {property.PropertyType}");
      Console.WriteLine($"(ID: {property.PropertyId} , Location : {property.Location}, Area : {property.Area})");
      Console.WriteLine($": {property.GetPropertyTax():F2}");
    }
}