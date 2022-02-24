using API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
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
