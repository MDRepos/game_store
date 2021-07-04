using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_backend.Data
{
    public class ProductEntity
    {
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public int Category { get; set; }
        public string[] Platform { get; set; }
    }
}