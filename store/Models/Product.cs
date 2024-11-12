using System.ComponentModel.DataAnnotations;

namespace store.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public DateOnly IntroducedDate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
