using Microsoft.EntityFrameworkCore;
using RestaurantPaymentSystem.Data.Models;

namespace RestaurantPaymentSystem.Data
{
    public class RestaurantContext : DbContext
    {
        //https://entityframeworkcore.com/approach-code-first

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
           : base(options)
        {

        }
        public DbSet<DishModel>? DishModels { get; set; }
        public DbSet<TableModel>? TableModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestaurantContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}


