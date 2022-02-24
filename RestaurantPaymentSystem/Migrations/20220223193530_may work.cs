using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantPaymentSystem.Migrations
{
    public partial class maywork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishModels_TableModels_TableModelTableId",
                table: "DishModels");

            migrationBuilder.DropIndex(
                name: "IX_DishModels_TableModelTableId",
                table: "DishModels");

            migrationBuilder.DropColumn(
                name: "TableModelTableId",
                table: "DishModels");

            migrationBuilder.CreateTable(
                name: "DishModelTableModel",
                columns: table => new
                {
                    DishModelsDishId = table.Column<int>(type: "int", nullable: false),
                    TableModelsTableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishModelTableModel", x => new { x.DishModelsDishId, x.TableModelsTableId });
                    table.ForeignKey(
                        name: "FK_DishModelTableModel_DishModels_DishModelsDishId",
                        column: x => x.DishModelsDishId,
                        principalTable: "DishModels",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishModelTableModel_TableModels_TableModelsTableId",
                        column: x => x.TableModelsTableId,
                        principalTable: "TableModels",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishModelTableModel_TableModelsTableId",
                table: "DishModelTableModel",
                column: "TableModelsTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishModelTableModel");

            migrationBuilder.AddColumn<int>(
                name: "TableModelTableId",
                table: "DishModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DishModels_TableModelTableId",
                table: "DishModels",
                column: "TableModelTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_DishModels_TableModels_TableModelTableId",
                table: "DishModels",
                column: "TableModelTableId",
                principalTable: "TableModels",
                principalColumn: "TableId");
        }
    }
}
