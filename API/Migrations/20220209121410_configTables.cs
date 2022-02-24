using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantPaymentSystem.Migrations
{
    public partial class configTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableModels",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableModels", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "DishModels",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DishPrice = table.Column<double>(type: "float", nullable: false),
                    TableModelTableId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishModels", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_DishModels_TableModels_TableModelTableId",
                        column: x => x.TableModelTableId,
                        principalTable: "TableModels",
                        principalColumn: "TableId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishModels_TableModelTableId",
                table: "DishModels",
                column: "TableModelTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishModels");

            migrationBuilder.DropTable(
                name: "TableModels");
        }
    }
}
