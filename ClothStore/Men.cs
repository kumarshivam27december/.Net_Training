using System;
class Men : Cloth
{
    public int size { get; set; }
    public bool return_cloth { get; set; }
    public Men(int clothId,int size) : base(clothId)
    {
        this.clothId = clothId;
        this.size = size;
        this.return_cloth = true;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"MEN ID: {clothId}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Return Option within a Week: {return_cloth}");
    }
}