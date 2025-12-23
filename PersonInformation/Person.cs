using System;
class Person
{
    private string _Name = "";
    private int _Age;
    private string _Address = "";


    public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value;
        }
    }


    public int Age
    {
        get
        {
            return _Age;
        }
        set
        {
            _Age = value;
        }
    }

    public string Address
    {
        get
        {
            return _Address;
        }
        set
        {
            _Address = value;
        }
    }

    public Person(string Name,int Age,string Address)
    {
        this.Name = Name;
        this.Age = Age;
        this.Address = Address;
    }

    public void Display()
    {
        Console.WriteLine("Person's Information: ");
        Console.WriteLine($"{Name}");
        Console.WriteLine($"{Age}");
        Console.WriteLine($"{Address}");
    }

}