﻿using System.ComponentModel.DataAnnotations;

namespace SuperMarket.Models
{
    public class Category
    {
        public int CategoryId {  get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; } = string.Empty;
    }
}
