using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECOMweb.Migrations
{
    /// <inheritdoc />
    public partial class manyManyConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigsId",
                table: "ConfigItems");

            migrationBuilder.DropIndex(
                name: "IX_ConfigItems_ProductConfigsId",
                table: "ConfigItems");

            migrationBuilder.DropColumn(
                name: "ProductConfigsId",
                table: "ConfigItems");

            migrationBuilder.CreateTable(
                name: "ConfigItemProductConfig",
                columns: table => new
                {
                    ConfigItemsId = table.Column<int>(type: "int", nullable: false),
                    ProductConfigsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigItemProductConfig", x => new { x.ConfigItemsId, x.ProductConfigsId });
                    table.ForeignKey(
                        name: "FK_ConfigItemProductConfig_ConfigItems_ConfigItemsId",
                        column: x => x.ConfigItemsId,
                        principalTable: "ConfigItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigItemProductConfig_ProductConfigs_ProductConfigsId",
                        column: x => x.ProductConfigsId,
                        principalTable: "ProductConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigItemProductConfig_ProductConfigsId",
                table: "ConfigItemProductConfig",
                column: "ProductConfigsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigItemProductConfig");

            migrationBuilder.AddColumn<int>(
                name: "ProductConfigsId",
                table: "ConfigItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ConfigItems_ProductConfigsId",
                table: "ConfigItems",
                column: "ProductConfigsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigsId",
                table: "ConfigItems",
                column: "ProductConfigsId",
                principalTable: "ProductConfigs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
