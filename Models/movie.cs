using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    [DisplayName("Film Adı")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    [DisplayName("Yayın Tarihi")]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Column(TypeName="decimal(18,2)")]
    public decimal Price { get; set; }
    public int? UnitsInStock { get; set; }

}