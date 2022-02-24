using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPaymentSystem.Data.Models;

namespace RestaurantPaymentSystem.Data.Configurations
{
    public class DishConfiguration : IEntityTypeConfiguration<DishModel>
    {
        public void Configure(EntityTypeBuilder<DishModel> modelBuilder)
        {
            //https://entityframeworkcore.com/model-relationships

            modelBuilder
                .HasKey(d => d.DishId);

            modelBuilder
                .HasOne(d => d.Table)
                .WithMany(t => t.DishModels);


        }
    }
}
