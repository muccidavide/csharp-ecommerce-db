﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Costumer
    {
        public int CostumerId { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }     
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}
