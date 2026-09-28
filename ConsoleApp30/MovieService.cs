public interface IMovieService
{
    void GetMovieByTitle(string title);
    void RemoveMovieById(int id);
}
public class MovieService: IMovieService
{
    private static List<Movie> _movies = new List<Movie>();
    public static void AddMovie(Movie movie)
    {
        if (_movies.Any(m => m.Title == movie.Title))
        {
            throw new ConflictException($"A movie with the title '{movie.Title}' already exists.");
        }
        _movies.Add(movie);
    }
    public void GetMovieByTitle(string title)
    {
        var movie = _movies.FirstOrDefault(m => m.Title == title);
        if (movie == null)
        {
            throw new NotFoundException($"No movie found with the title '{title}'.");
        }
        Console.WriteLine(movie);
    }
    public void RemoveMovieById(int id)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            throw new NotFoundException($"No movie found with the ID '{id}'.");
        }
        _movies.Remove(movie);
    }
}