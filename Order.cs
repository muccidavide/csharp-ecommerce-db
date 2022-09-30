
using csharp_ecommerce_db;

public class Order
{
    public int OrderId { get; set; }
    public string Date { get; set; }
    public int Amount { get; set; }
    public string Status { get; set; }
    public List<Payment> Payments { get; set; }
    public List<Product> Products { get; set; }
    public int CostumerId { get; set; }
    public Costumer Costumer { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}