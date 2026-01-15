public class Problem2
{
    public static List<Movie> MovieList = new List<Movie>();

    public static void Demo()
    {
        while (true)
        {
            Console.WriteLine("Enter the values");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. List Movie");
            Console.WriteLine("3. View Movie by Genre");
            Console.WriteLine("4. ViewMoviesByRating");
            Console.WriteLine("5. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the title");
                    string title = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter the Artist");
                    string artist = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter the Genre");
                    string genre = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter the rating");
                    string rating = Console.ReadLine() ?? "";
                    string details = title + " " + artist + " " + genre + " " + rating;
                    Movie movie = new Movie();
                    movie.AddMovie(details);
                    break;
                case 2:
                    foreach (var item in MovieList)
                    {
                        Console.WriteLine($"{item.Title} {item.Artist}");
                    }
                    break;
                case 3:
                    string genre1 = Console.ReadLine() ?? "";
                    Console.WriteLine("Enter the rating");
                    Movie movie1 = new Movie();
                    List<Movie> getMovieByGenre = movie1.ViewMoviesByGenre(genre1);

                    foreach (var item in getMovieByGenre)
                    {
                        Console.WriteLine($"{item.Title} {item.Genre}");
                    }
                    break;
                case 4:
                    Movie movie2 = new Movie();
                    List<Movie> getMovieByrating = movie2.ViewMoviesByRatings();

                    foreach (var item in getMovieByrating)
                    {
                        Console.WriteLine($"{item.Title} {item.Rating}");
                    }
                    break;
                    
                case 5:
                    Console.WriteLine("Exiting......");
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}


public class Movie
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public string Genre { get; set; }
    public int Rating { get; set; }

    public void AddMovie(string MovieDetails)
    {
        string[] moviedetails = MovieDetails.Split(" ");

        string title = moviedetails[0];
        string artist = moviedetails[1];
        string genre = moviedetails[2];
        int rating = Convert.ToInt32(moviedetails[3]);

        

        Movie movie = new Movie()
        {
            Title = title,
            Artist = artist,
            Genre = genre,
            Rating = rating
        };

        Problem2.MovieList.Add(movie);
    }

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        var viewmoviebygenre = Problem2.MovieList.Where(e => e.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase)).ToList();
        return viewmoviebygenre;
    }


        public List<Movie> ViewMoviesByRatings()
        {
            var viewmoviebyrating = Problem2.MovieList.OrderBy(e=>e.Rating).ToList();
            return viewmoviebyrating;
        }
}