using Northwind.DataAccess.Concrate.EntityFramework.Mappings;
using Northwind.Entities.Concrate;
using System.Data;
using System.Data.Entity;

namespace Northwind.DataAccess.Concrate.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
