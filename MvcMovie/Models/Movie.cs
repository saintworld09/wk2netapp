using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(60)]
    public string? Title { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Range(1, 1000)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Required]
    public string? Rating { get; set; }
}
