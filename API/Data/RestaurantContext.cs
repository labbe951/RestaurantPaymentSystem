using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RestaurantContext : DbContext
    {
        //https://entityframeworkcore.com/approach-code-first

        public DbSet<DishModel>? DishModels { get; set; }
        public DbSet<TableModel>? TableModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RestaurantDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestaurantContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}


