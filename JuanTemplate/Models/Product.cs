﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JuanTemplate.Models
{
    public class Product : BaseEntity
    {


        [StringLength(255)]
        public string Title { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "money")]
        public double DiscountedPrice { get; set; }
        [Column(TypeName = "money")]
        public double ExTax { get; set; }
        public int Count { get; set; }
        public bool IsTopSeller { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [StringLength(4, MinimumLength = 4)]
        public string? Seria { get; set; }
        public int? Code { get; set; }
        [StringLength(255)]
        public string? MainImage { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


        public IEnumerable<ProductImage>? ProductImages { get; set; }

        [NotMapped]
        public IEnumerable<byte>? TagIds { get; set; }
        [NotMapped]
        public IEnumerable<IFormFile>? Files { get; set; }
        [NotMapped]
        public IFormFile? MainFile { get; set; }



    }
}
