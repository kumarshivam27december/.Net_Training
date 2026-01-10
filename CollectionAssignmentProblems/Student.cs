using System.Collections;

class Student
{
    private static ArrayList arrayList = new ArrayList();
    private static void AddInCollection(string name)
    {
        if (!IsValidName(name))
        {
            Console.WriteLine("input is not valid");
        }
        if (IsNameInCollection( arrayList, name))
        {
            Console.WriteLine($"{name} is already in the collection.");
            return;
        }
        arrayList.Add(name.ToLower());
        Console.WriteLine($"{name} added to the collection");
    }
    private static bool IsValidName(string name)
    {
        return name!=null && name!="";
    }
    private static bool IsNameInCollection(ArrayList studentNames,string names)
    {
        if (studentNames.Contains(names.ToLower()))
        {
            return true;
        }
        return false;
    }
    private static void DisplayStudentNames(ArrayList studentNames)
    {
        Console.WriteLine("Unique student names entered:");
        foreach (var item in studentNames)
        {
            Console.WriteLine(item);
        }
    }
    public static void Demo()
    {
        Student student = new Student();
        string inputString;
        while (true)
        {
            inputString = Console.ReadLine() ?? "";
            if (inputString == "stop")
            {
                break;
            }
            AddInCollection(inputString);
        }
        DisplayStudentNames(arrayList);
    }
}