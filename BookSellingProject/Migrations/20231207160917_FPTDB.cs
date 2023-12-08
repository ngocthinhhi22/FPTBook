using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookSellingProject.Migrations
{
    /// <inheritdoc />
    public partial class FPTDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Books_BookId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Books_BookId",
                table: "CartItems",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
