using System;
class Women : Cloth
{
    public string Materialtype { get; set; }
    public int size { get; set; }
    public bool return_cloth { get; set; }
    public Women(int clothId,int size,string Materialtype) : base(clothId)
    {
        this.clothId = clothId;
        this.size = size;
        this.Materialtype = Materialtype ?? "";
        this.return_cloth = true;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Women Cloth Id : {clothId}");
        Console.WriteLine($"Size : {clothId}");

        Console.WriteLine($"Material Type: {Materialtype}");
        Console.WriteLine($"Return Option within a Week: {return_cloth}");

    }
    
}