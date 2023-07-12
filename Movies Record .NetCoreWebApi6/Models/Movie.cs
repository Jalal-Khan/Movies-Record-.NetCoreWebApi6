namespace Movies_Record_.NetCoreWebApi6.Models
{
    public class Movie
    {
        public int Id { get;set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime RealeaseDate { get; set; }
    }
}
