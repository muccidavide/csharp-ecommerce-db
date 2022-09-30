﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
