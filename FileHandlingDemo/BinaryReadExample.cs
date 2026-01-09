using System;
using System.IO;
class BinaryReadExample
{
    public static void Main2()
    {
        string filepath = "employee.dat";
        using (FileStream fs = new FileStream(filepath,FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            double salary = reader.ReadDouble();
            bool isactive = reader.ReadBoolean();

            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"salary : {salary}");
            Console.WriteLine($"isactive : {isactive}");
        }
    }
}