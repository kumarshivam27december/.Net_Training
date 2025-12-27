using System;
class Kid : Cloth
{
    public int size { get; set; }
    public bool return_cloth { get; set; }
    public Kid(int clothId,int size) : base(clothId )
    {
        this.clothId = clothId;
        this.size = size;
        this.return_cloth = true;
    }

    

    public void DisplayInfo()
    {
        Console.WriteLine($"KID Cloth Id: {clothId}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Return Option Within a Week: {return_cloth}");
    }
}