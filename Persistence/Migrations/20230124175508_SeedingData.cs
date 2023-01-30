using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCart.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductInfos",
                columns: new[] { "Id", "Category", "Description", "IsStockAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Phone", "Test description 1", true, "Test 1", 10 },
                    { 2, "Phone", "Test description 2", true, "Test 2", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
