using System.ComponentModel.DataAnnotations;

namespace store.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        // Navigation property to Order
        public Order Order { get; set; }
        public Product Product { get; set; }  // เพิ่มการเชื่อมโยงกับ Product
    }
}
