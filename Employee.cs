using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Employee
    {
        public Employee(string name, string surname, string level)
        {
            Name = name;
            Surname = surname;
            Level = level;
        }

        public Employee(string name, string surname, string level, List<Order> orders) : this(name, surname, level)
        {
            Orders = orders;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Level { get; set; }
        public List<Order> Orders { get; set; } 

    }
}
