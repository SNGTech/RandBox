using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
	public class SubscriptionItem
	{
        public int SubscriptionItemID { get; set; }
        public int Qty { get; set; }
        public int MonthOfYear { get; set; }
        public int ProductID { get; set; }
        public virtual Product? Product { get; set; }
        public int SubscriptionPlanID { get; set; }
        public virtual SubscriptionPlan? SubscriptionPlan { get; set; }
    }
}
