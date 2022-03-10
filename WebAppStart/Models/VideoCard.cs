using System.ComponentModel.DataAnnotations;
namespace WebAppStart.Models
{
    public class VideoCard
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string? NameCard { get; set; }
        [Display(Name = "Производитель")]
        public string? Manufacturer { get; set; }
        [Display(Name ="Серия")]
        public string? Series { get; set; }
        [Display(Name ="Модель")]
        public string? Model { get; set; }
        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="Цена")]
        public decimal Price { get; set; }

    }
}
