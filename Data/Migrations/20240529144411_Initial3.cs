using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BusketId",
                table: "OrderItems",
                column: "BusketId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Buskets_BusketId",
                table: "OrderItems",
                column: "BusketId",
                principalTable: "Buskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Buskets_BusketId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_BusketId",
                table: "OrderItems");
        }
    }
}
