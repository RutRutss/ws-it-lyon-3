using store.Models;
using System.ComponentModel.DataAnnotations;

public class Order
{
    [Key]
    public int OrderId { get; set; }  // ควรเป็น int
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }  // ใช้ decimal สำหรับจำนวนเงิน
    public string OrderStatus { get; set; }  // ใช้ enum สำหรับสถานะ
    public int CustomerId { get; set; }  // ควรเป็น int

    // Navigation properties
    public Customer Customer { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
