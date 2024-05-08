using System.ComponentModel.DataAnnotations;

namespace App_movie.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public string? ImageUrl { get; set; }
        public float? SumOfRate { get; set; }
        public int? CountRate { get; set; }
    }
}
