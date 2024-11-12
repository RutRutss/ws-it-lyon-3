using System.ComponentModel.DataAnnotations;

namespace store.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public ICollection<Order> Orders { get; set; } // เพิ่มการเชื่อมโยง
    }
}
