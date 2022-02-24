using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantPaymentSystem.Migrations
{
    public partial class SeedDishes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                INSERT INTO [dbo].[DishModels] ([DishName],[DishPrice])
                VALUES
                ('Carbonara', 85 ),
                ('Bolognese', 99 ),
                ('Saporita', 101 ),
                ('AlAglio', 79 );

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
