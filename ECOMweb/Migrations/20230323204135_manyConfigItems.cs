using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECOMweb.Migrations
{
    /// <inheritdoc />
    public partial class manyConfigItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigId",
                table: "ConfigItems");

            migrationBuilder.RenameColumn(
                name: "ProductConfigId",
                table: "ConfigItems",
                newName: "ProductConfigsId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigItems_ProductConfigId",
                table: "ConfigItems",
                newName: "IX_ConfigItems_ProductConfigsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigsId",
                table: "ConfigItems",
                column: "ProductConfigsId",
                principalTable: "ProductConfigs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigsId",
                table: "ConfigItems");

            migrationBuilder.RenameColumn(
                name: "ProductConfigsId",
                table: "ConfigItems",
                newName: "ProductConfigId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigItems_ProductConfigsId",
                table: "ConfigItems",
                newName: "IX_ConfigItems_ProductConfigId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigItems_ProductConfigs_ProductConfigId",
                table: "ConfigItems",
                column: "ProductConfigId",
                principalTable: "ProductConfigs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
