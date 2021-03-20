using System;
using System.ComponentModel.DataAnnotations;

namespace ApiProduct.Models
{
    public class Product
    {
        [Key]
        [Range(1, 99999)]
        public int ProductId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public float Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }
    }
}