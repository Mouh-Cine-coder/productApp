using System.ComponentModel.DataAnnotations;

namespace productApp.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>();
    }

    
}
