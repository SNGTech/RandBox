using System.ComponentModel.DataAnnotations;

namespace RandBox.Shared.Domain
{
	public class SubscriptionPlan
	{
        [Key]
        public int SubscriptionPlanID { get; set; }
		public DateTime SubscribedDateTime { get; set; }
        public int? CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
		public int? SubscriptionCategoryID { get; set; }
        public virtual SubscriptionCategory? SubscriptionCategory { get; set; }
        public int? StaffID { get; set; }
		public virtual Staff? Staff { get; set; }
        public virtual List<SubscriptionItem>? SubscriptionItems { get; set; }
	}
}
