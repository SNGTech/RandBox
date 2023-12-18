namespace RandBox.Shared.Domain
{
	public class SubscriptionCategory
	{
		public int SubscriptionCategoryID { get; set; }
		public string? Description { get; set; }
        public int Duration { get; set; }
		public decimal BaseMonthlyPrice { get; set; }
		public decimal NewMonthlyPrice { get; set; }
		public int CategoryID { get; set; }
        public virtual List<Category>? Categories { get; set; }
    }
}