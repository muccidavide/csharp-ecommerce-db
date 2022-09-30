
using csharp_ecommerce_db;

public class Order
{
    public Order(DateTime date, int amount, string status)
    {
        Date = date;
        Amount = amount;
        Status = status;
    }

    public Order(DateTime date, int amount, string status, List<Payment> payments, List<Product> products, Costumer costumer, Employee employee) : this(date, amount, status)
    {
        Costumer = costumer;
        Employee = employee;
    }

    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string Status { get; set; }
    public List<Payment> Payments { get; set; }
    public List<Product> Products { get; set; }
    public int CostumerId { get; set; }
    public Costumer Costumer { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}