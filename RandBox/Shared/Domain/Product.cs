using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RandBox.Shared.Domain
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? ThumbnailURL { get; set; }
        public int? StockNo { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal OriginalPrice { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal DiscountedPrice { get; set; }
        
        public DateTime? ManufacturedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? CountryID { get; set; }
        public virtual Country? Country { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category? Category { get; set; }

 
    }
}
