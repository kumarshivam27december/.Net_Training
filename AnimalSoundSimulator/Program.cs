using System;
class Program
{
    public static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());

        if (input <= 0)
        {
            Console.WriteLine("please enter valid input above 0");
            input = Convert.ToInt32(Console.ReadLine());
        }

        string[] inputArr = new string [input];

        for(int i  = 0; i < input; i++)
        {
            inputArr[i] =  Console.ReadLine() ?? "";
        }

        foreach (string item in inputArr)
        {
            if (item == "animal")
            {
                Animal animal = new Animal();
                animal.MakeSound();
            }else if(item == "dog")
            {
                Animal animal = new Dog();
                animal.MakeSound();
            }else if(item == "cat")
            {
                Animal animal = new Cat();
                animal.MakeSound();
            }
            else
            {
                Console.WriteLine("Invalid animal species");
            }
        }

    }
}