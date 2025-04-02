using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentTable",
                columns: new[] { "Id", "Email", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 101, "ssusuuusis", "Steve", 8838339, "Smith" },
                    { 102, "ssusuuusis", "Sara", 8838339, "Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "StudentTable",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
