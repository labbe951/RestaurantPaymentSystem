// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RestaurantPaymentSystem.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20220224122256_FixedOneTable")]
    partial class FixedOneTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Data.Models.DishModel", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DishId"), 1L, 1);

                    b.Property<string>("DishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DishPrice")
                        .HasColumnType("float");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("TableId");

                    b.ToTable("DishModels");
                });

            modelBuilder.Entity("API.Data.Models.TableModel", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"), 1L, 1);

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.ToTable("TableModels");
                });

            modelBuilder.Entity("API.Data.Models.DishModel", b =>
                {
                    b.HasOne("API.Data.Models.TableModel", "Table")
                        .WithMany("DishModels")
                        .HasForeignKey("TableId");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("API.Data.Models.TableModel", b =>
                {
                    b.Navigation("DishModels");
                });
#pragma warning restore 612, 618
        }
    }
}
