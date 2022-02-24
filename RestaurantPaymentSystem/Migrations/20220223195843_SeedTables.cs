using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantPaymentSystem.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                INSERT INTO [dbo].[TableModels] ([TableNumber])
                VALUES
                (11),
                (12),
                (13),
                (14),
                (15),
                (16),
                (17),
                (18),
                (19),
                (20),
                (21);

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
