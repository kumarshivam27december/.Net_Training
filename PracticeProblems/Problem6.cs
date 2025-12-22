class Problem6
{
    public static void Solve()
    {
        float radius;
        System.Console.Write("Please enter the radius of the circle");
        radius = Convert.ToSingle(System.Console.ReadLine());
        float area = 3.14f*radius*radius;
        System.Console.WriteLine($"The area of the circle is {area}");
    }
}