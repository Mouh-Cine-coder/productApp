using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using productApp.Models;

namespace productApp.Data
{
    public class productAppContext : DbContext
    {
        public productAppContext (DbContextOptions<productAppContext> options)
            : base(options)
        {
        }

        public DbSet<productApp.Models.Entreprise> Entreprise { get; set; } = default!;
        public DbSet<productApp.Models.Product> Product { get; set; } = default!;
        public DbSet<productApp.Models.ShoppingList> ShoppingList { get; set; } = default!;
    }
}
