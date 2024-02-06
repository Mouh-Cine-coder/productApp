using productApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace productApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public ProductCategory ProductCategory { get; set; }

        // Entreprise
        public int EntrepriseId { get; set; }
        [ForeignKey("EntrepriseId")]
        public Entreprise entreprise { get; set; }

        // shopping list 
        public int ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; } = null!;
        

    }
}
