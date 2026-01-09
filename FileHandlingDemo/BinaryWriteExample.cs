class BinaryWriteExample
{
    public static void Main1()
    {
        string filepath = "employee.dat";
        using (FileStream fs = new FileStream(filepath,FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);
            writer.Write("ravi");
            writer.Write(45000.75);
            writer.Write(true);
        }
        Console.WriteLine("Binary file written successfully");
    }
}