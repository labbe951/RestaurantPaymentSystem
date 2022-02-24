using API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
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
