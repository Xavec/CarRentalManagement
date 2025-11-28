using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(2847), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(2868), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3183), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3316), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 11, 28, 10, 23, 58, 444, DateTimeKind.Local).AddTicks(3320) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7611), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7630), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7913), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8045), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8049), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8050), new DateTime(2025, 11, 28, 10, 11, 42, 778, DateTimeKind.Local).AddTicks(8051) });
        }
    }
}
