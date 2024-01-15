﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandBox.Shared.Domain
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public int? Qty { get; set; }
        public int? OrderID { get; set; }
        public virtual Orders? Order { get; set; }
        public int? ProductID { get; set; }
        public virtual Product? Product { get; set; }
    }
}
