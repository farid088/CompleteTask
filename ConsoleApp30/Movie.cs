public class Movie
{
    public static int IdCounter = 1;
    public Movie( )
    {
        Id = IdCounter++;
        CreatedAt = DateTime.Now;


    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } 
    public DateTime CreatedAt { get; set; } 
    public string Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public  MovieStatus Status { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Description: {Description}, CreatedAt: {CreatedAt}, Duration: {Duration}, ReleaseDate: {ReleaseDate}, Status: {Status}";
    }
}