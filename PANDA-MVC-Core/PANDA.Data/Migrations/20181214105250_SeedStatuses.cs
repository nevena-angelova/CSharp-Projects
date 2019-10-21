using Microsoft.EntityFrameworkCore.Migrations;

namespace PANDA.Data.Migrations
{
    public partial class SeedStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PackageStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Shipped" },
                    { 3, "Delivered" },
                    { 4, "Acquired" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PackageStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PackageStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PackageStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PackageStatuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
