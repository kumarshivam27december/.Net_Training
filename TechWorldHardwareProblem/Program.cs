public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Desktop\n 2.Laptop \nChoose the option");
        int choose = Convert.ToInt32(Console.ReadLine());

        

        if (choose == 1)
        {
            
            Console.WriteLine("Enter the Processor");
            string processorType = Console.ReadLine();
            Console.WriteLine("Enter the ram size");
            int ramSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size");
            int hardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the graphic size");
            int graphicSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the monitor size");
            int monitorSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power supply vold");
            int powerSupplyVolt = Convert.ToInt32(Console.ReadLine());
            Desktop computer = new Desktop
            {
                Processor = processorType,
                RamSize = ramSize,
                HardDiskSize = hardDiskSize,
                GraphicCard = graphicSize,
                MonitorSize = monitorSize,
                PowerSupplyVolt = powerSupplyVolt
            };
            double desktopPrice = computer.DesktopPriceCalculation();
            Console.WriteLine("Desktop Price is " + desktopPrice);
        }
        else if (choose == 2)
        {
            Console.WriteLine("Enter the Processor");
            string processorType = Console.ReadLine();
            Console.WriteLine("Enter the ram size");
            int ramSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size");
            int hardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the graphic size");
            int graphicSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Display size");
            int DisplaySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Battery  vold");
            int BatterVolt = Convert.ToInt32(Console.ReadLine());

            Laptop computer = new Laptop
            {
                Processor = processorType,
                RamSize = ramSize,
                HardDiskSize = hardDiskSize,
                GraphicCard = graphicSize,
                DisplaySize = DisplaySize,
                BatteryVolt = BatterVolt,
            };
            double laptopPrice = computer.LaptopPriceCalculation();
            Console.WriteLine("Desktop Price is " + laptopPrice);

        }
        else
        {
            Console.WriteLine("Invalid Choice");
            return;
        }

    }
}
class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }

   
}

class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }
    public double DesktopPriceCalculation()
    {
        double ProcessorCost = 0.0;
        if (Processor == "i3")
        {
            ProcessorCost = 1500;
        }
        else if (Processor == "i5")
        {
            ProcessorCost = 3000;
        }
        else if (Processor == "i7")
        {
            ProcessorCost = 4500;
        }

        double Ramprice = 200;
        double HarddiskPrice = 1500;
        double GraphicCardPrice = 2500;
        double PowersupplyPrice = 20;
        double Monitorprice = 250;

        double DP = ProcessorCost + (RamSize * Ramprice) + (HardDiskSize * HarddiskPrice) +(GraphicCard * GraphicCardPrice) + (MonitorSize * Monitorprice) + (PowerSupplyVolt * PowersupplyPrice);


        return DP;
    }
}

class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        double ProcessorCost = 0;
        if (Processor == "i3")
        {
            ProcessorCost = 1500;
        }
        else if (Processor == "i5")
        {
            ProcessorCost = 3000;
        }
        else if (Processor == "i7")
        {
            ProcessorCost = 4500;
        }

        double Ramprice = 200;
        double HarddiskPrice = 1500;
        double GraphicCardPrice = 2500;
        double BatteryPrice = 20;
        double Displayprice = 250;

        double LP = ProcessorCost + (RamSize * Ramprice) + (HardDiskSize * HarddiskPrice) +(GraphicCard * GraphicCardPrice) + (DisplaySize * Displayprice) + (BatteryVolt * BatteryPrice);

        return LP;

    }

}