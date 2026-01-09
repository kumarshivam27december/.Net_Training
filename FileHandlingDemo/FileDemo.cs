class FileDemo
{
    public void WriteTextData()
    {
        FileStream fileStream = new FileStream(@"C:\Users\91995\Desktop\net\FileHandlingDemo\Test.txt",FileMode.Append,FileAccess.Write);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        Console.WriteLine("Enter some text");
        string str = Console.ReadLine() ?? "";
        streamWriter.WriteLine(str);

        streamWriter.Close();
        fileStream.Close();
    }

    public void ReadTextData()
    {
        FileStream fileStream = new FileStream(@"C:\Users\91995\Desktop\net\FileHandlingDemo\Test.txt",FileMode.Open,FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileStream);
        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str = streamReader.ReadLine() ?? "";
        while (str!=null)
        {
            Console.WriteLine(str);
            str = streamReader.ReadLine() ?? "";
        }

        streamReader.Close();
        fileStream.Close();
    }

}