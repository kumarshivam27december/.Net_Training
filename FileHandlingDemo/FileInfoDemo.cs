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

        string path = @"Data1\Test.txt";
        string path2 = @"Data2\newTest1.txt";
        FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);

        fi1.MoveTo(path2);
        Console.WriteLine($"{path} was copied to {path2}");
        
    }
}