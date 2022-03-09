using System.ComponentModel.DataAnnotations;
namespace WebAppStart.Models
{
    public class VideoCard
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? NameCard { get; set; }
        public string? Manufacturer { get; set; }
        public string? Series { get; set; }
        public string? Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

    }
}
