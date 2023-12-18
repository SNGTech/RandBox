using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandBox.Shared.Domain
{
    public class SubscriptionCategory
	{
        [Key]
        public int SubscriptionCategoryID { get; set; }
		public string? Description { get; set; }
        public int Duration { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal BaseMonthlyPrice { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal NewMonthlyPrice { get; set; }
		public int? CategoryID { get; set; }
        public virtual List<Category>? Categories { get; set; }
    }
}