using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
	public class SubscriptionPlan
	{
        [Key]
        public int SubscriptionPlanID { get; set; }
		public DateTime SubscribedDateTime { get; set; }
        public int? CustID { get; set; }
        public virtual List<Customer>? Customers { get; set; }
		public int? SubscriptionCategoryID { get; set; }
        public virtual List<SubscriptionCategory>? SubscriptionCategories { get; set; }
        public int? StaffID { get; set; }
		public virtual List<Staff>? Staff { get; set; }
	}
}
