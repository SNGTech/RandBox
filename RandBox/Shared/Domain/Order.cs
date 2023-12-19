using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime DateTimeCheckout { get; set; }
        public Boolean DeliveryStatus { get; set; }
        public int? CustomerID { get; set; }
        public virtual List<Customer>? Customer { get; set; }
        public int? StaffID { get; set; }
        public virtual List<Staff>? Staff { get; set; }

    }
}
