using System.ComponentModel.DataAnnotations;

namespace productApp.Models
{
    public class Entreprise
    {
        [Key]
        public int Id { get; set; }

        public string EntrepriseLogoURL { get; set; }

        public string NomEntreprise { get; set; }

        public string Discription { get; set; }
        
        // one to many relationship: entreprise has many products, and a products belong to one entreprise
        public List<Product> Products { get; set; }
    }
}
