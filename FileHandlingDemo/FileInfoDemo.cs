using System.Data.SqlTypes;
using System.IO;
class FileInfoDemo
{
    public static void Main3()
    {
        /* 
        //file creating
        string path = @"MyTestfile.txt";
        FileInfo fileInfo = new FileInfo(path);
        File.Create(path);
        {
            Console.WriteLine("File has been created");
        }
        */

        /*
        //this method is used to delete an existing file
        FileInfo fileInfo1 = new FileInfo(@"Mytestfile.txt");
        fileInfo1.Delete();
        Console.WriteLine("file has been deleted");
        */

        /*
        //the copyto method is used to copy an existing file into a new file
        string path = @"Data1\Test.txt";
        string path2 = @"Data2\newTest.txt";
        FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);

        fi1.CopyTo(path2);
        Console.WriteLine($"{path} was copied to {path2}");
        */

        /*
        string path = @"Data1\Test.txt";
        string path2 = @"Data2\newTest1.txt";
        FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);

        fi1.MoveTo(path2);
        Console.WriteLine($"{path} was copied to {path2}");
        */


        /*

        FileInfo f1 = new FileInfo(@"Data1\NewFile1.txt");
        StreamWriter streamWriter =  f1.AppendText();
        streamWriter.WriteLine("this");
        streamWriter.WriteLine("is");
        streamWriter.WriteLine("extra");

        Console.WriteLine("file has been appended successfully");
        streamWriter.Close();


        */



        FileInfo f1 = new FileInfo(@"employee.dat");
        StreamReader sr = f1.OpenText();
        string s= "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }

        // FileInfo fi = new FileInfo(@"Data2\NewTest1.txt");
        // Console.WriteLine("File name is {0}",fi.Name);
        // Console.WriteLine("File created at {0}",fi.CreationTime);
        // Console.WriteLine("File length is {0}",fi.Length);
        // Console.WriteLine("File extension is {0}",fi.Extension);
        // Console.WriteLine("File exist is {0}",fi.Exists);
        
               

    }
}