using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Buskets_BusketId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusketId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusketId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BusketId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "BusketId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusketId",
                table: "Users",
                column: "BusketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Buskets_BusketId",
                table: "Users",
                column: "BusketId",
                principalTable: "Buskets",
                principalColumn: "Id");
        }
    }
}
