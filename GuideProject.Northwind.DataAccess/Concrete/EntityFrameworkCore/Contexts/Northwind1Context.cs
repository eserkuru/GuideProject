using GuideProject.Northwind.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuideProject.Northwind.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class Northwind1Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind1; Trusted_Connection=true");
        }
        public DbSet<Category> Categories { get; set; }

    }
}
