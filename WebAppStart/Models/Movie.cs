﻿using System.ComponentModel.DataAnnotations;

namespace WebAppStart.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string? Title { get; set; }
        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="Жанр")]
        public string? Genre { get; set; }
        [Display(Name ="Цена")]
        public decimal Price { get; set; }
    }
}
