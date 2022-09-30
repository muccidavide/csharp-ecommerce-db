using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Product
    {
        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public Product(string name, string description, double price, List<Order> orders) : this(name, description, price)
        {
            Orders = orders;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
