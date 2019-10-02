using GuideProject.Northwind.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuideProject.Northwind.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class Northwind2Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind2; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }

    }
}
