using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7422), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7784), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7786), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7788), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7790), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7956), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7958), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7959), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7961), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7962), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7964), new DateTime(2025, 11, 24, 11, 48, 11, 728, DateTimeKind.Local).AddTicks(7965), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 45, 30, 230, DateTimeKind.Local).AddTicks(5285), new DateTime(2025, 11, 24, 11, 45, 30, 230, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 45, 30, 230, DateTimeKind.Local).AddTicks(5306), new DateTime(2025, 11, 24, 11, 45, 30, 230, DateTimeKind.Local).AddTicks(5306) });
        }
    }
}
