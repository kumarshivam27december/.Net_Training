using System.Buffers;
using System.Net.Sockets;

class Program
{
    
    public static void Main(string[] args)
    {
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput <= 0)
        {
            Console.WriteLine("Please Enter valid Input");
            return;
        }

        PropertyManager propertyManager = new PropertyManager();


        while (userInput-- > 0)
        {
            int PropertyId = Convert.ToInt32(Console.ReadLine());
            string Location = Console.ReadLine();
            double Area = Convert.ToDouble(Console.ReadLine());
            string PropertyType = Console.ReadLine();

            Location = Location.ToLower();
            PropertyType = PropertyType.ToLower();

            Property property = null;

            switch (PropertyType.ToLower())
            {
                case "house":
                    property = new House();
                    break;
                case "apartment":
                    property = new Apartment();
                    break;
                case "commercialBuilding":
                    property = new CommercialBuilding();
                    break;
                default:
                    Console.WriteLine("Invalid Property type");
                    return;
            }
            property.PropertyId = PropertyId;
            property.Location = Location;
            property.Area = Area;
            propertyManager.PrintPropertyTax(property);
        }
    }
}