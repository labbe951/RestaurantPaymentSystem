using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPaymentSystem.Data.Models;

namespace RestaurantPaymentSystem.Data.Configurations
{
    public class TableConfiguration : IEntityTypeConfiguration<TableModel>
    {
        public void Configure(EntityTypeBuilder<TableModel> modelBuilder)
        {
            modelBuilder
                .HasKey(t => t.TableId);

            modelBuilder
                .HasMany(t => t.DishModels)
                .WithOne(d => d.Table);
        }
    }
}
