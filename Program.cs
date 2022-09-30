using Microsoft.EntityFrameworkCore;
using csharp_ecommerce_db;


ECommerceContext db = new ECommerceContext();

/*
 CRUD TABLES
 */

// CREATE

Order order1 = new Order(new DateTime(2008, 3, 1, 7, 0, 0), 33, "completed");
Order order2 = new Order(new DateTime(2021, 3, 1, 7, 0, 0), 23, "completed");
Order order3 = new Order(new DateTime(2018, 3, 1, 7, 0, 0), 3, "completed");

Costumer costumer1 = new Costumer("Davide", "Mucci", "davidemucci@email.com");
Costumer costumer2 = new Costumer("Anna", "Rossi", "annarossi@email.com");
Costumer costumer3 = new Costumer("Luca", "Bianchi", "lucabianchi@email.com");

Employee employee1 = new Employee("Marco", "Ward", "Junior Developer");
Employee employee2 = new Employee("Sara", "Brambilla", "Senior Developer");
Employee employee3 = new Employee("Gianni", "Fumagalli", "Java Junior Developer");

Payment payment1 = new Payment(new DateTime(2008, 3, 1, 7, 0, 0), 30, "transaction completed");
Payment payment2 = new Payment(new DateTime(2021, 3, 1, 7, 0, 0), 30, "transaction completed");
Payment payment3 = new Payment(new DateTime(2018, 3, 1, 7, 0, 0), 30, "transaction completed");
Payment payment4 = new Payment(new DateTime(2020, 2, 1, 6, 0, 0), 30, "transaction failed");

Product shirt = new Product("Maglietta Dolce Gabbana", "Maglietta in seta di D&G", 86.33f);
Product pants = new Product("Pantaloni", "Pantaloni di Armani", 36.00f);
Product golf = new Product("Golf di lana", "Golf di lana di D&G", 186.10f);

List<Product> products1 = new List<Product>() { shirt,pants,golf};
List<Product> products2 = new List<Product>() { pants, golf };
List<Product> products3 = new List<Product>() { pants };

List<Payment> payments = new List<Payment>() { payment1,payment2,payment3,payment4 };

Order order4 = new Order(new DateTime(2018, 3, 1, 7, 0, 0), 3, "completed",payments, products1,costumer1, employee1);

/*db.Products.Add(shirt);
db.Products.Add(pants);
db.Products.Add(golf);*/

  /*
order1.Costumer = costumer1;
order1.Employee = employee1;

db.Orders.Add(order1);
db.SaveChanges();

order2.Costumer = costumer2;
order3.Costumer = costumer3;
order2.Employee = employee2;
order3.Employee = employee3;

payment1.Order = order1;
payment2.Order = order2;
payment3.Order = order3;
payment4.Order = order3;

db.Orders.Add(order2);
db.Orders.Add(order3);
db.Payments.Add(payment1);
db.Payments.Add(payment2);
db.Payments.Add(payment3);
db.Payments.Add(payment4);

db.SaveChanges();
*/



