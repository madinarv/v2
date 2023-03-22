﻿using System.ComponentModel.DataAnnotations;

namespace JuanTemplate.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product>? Products { get; set; }

    }
}
