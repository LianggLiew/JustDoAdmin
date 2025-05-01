using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Display(Name = "Product Name")]
        public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Description")]
        public string? Description { get; set; }
        
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        
        [Display(Name = "Stock")]
        public int Stock { get; set; }
        
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}