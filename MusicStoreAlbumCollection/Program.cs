using System.Collections;

public class Program
{
    public static void Main(string[] args)
    { 
        ArrayList albums = new ArrayList();  
        while (true)
        {
            string input1 = Console.ReadLine() ?? "";
            if (input1 == "quit")
            {
                break;
            }
            string input2 = Console.ReadLine() ?? "";
            if (input2 == "quit")
            {
                break;
            } 
            AddData(input1,input2,albums);
        }
        DisplayAlbums(albums);
    }
    private static void AddData(string title,string artist,ArrayList albums)
    {
        if (!IsValidInput(title))
        {
            Console.WriteLine("Invalid title");
            return;
        }

        if (!IsValidInput(artist))
        {
            Console.WriteLine("Invalid artist");
            return;
        }
        Album album = new Album();
        album.Title = title;
        album.Artist = artist;
        albums.Add(album);
    }

    private static void DisplayAlbums(ArrayList albums)
    {
        foreach (Album album in albums)
        {
            Console.WriteLine($"Title: {album.Title}, Artist: {album.Artist}");
        }
    }
    private static bool IsValidInput(string input)
    {
        if(input is null)
        {
            return false;
        }
        if(input == "" || input == " ")
        {
            return false;
        }
        return true;
    }

}

public class Album
{
    public string Title { get; set; }
    public string Artist { get; set; }
}