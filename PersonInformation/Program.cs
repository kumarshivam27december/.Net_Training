using System;
class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine() ??"";
        int age = Convert.ToInt32(Console.ReadLine());
        string Address = Console.ReadLine() ?? "";

        Person person = new Person(name,age,Address);
        person.Display();
    }
}