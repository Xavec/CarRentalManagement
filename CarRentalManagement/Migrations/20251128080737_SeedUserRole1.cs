using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9cf35f13-8203-4e6d-b36f-8c4408f2466d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFwey7B+5fqHbr/3jOuJsT/6aX5xe/qvRTx4CbLscOsPCBtb60SYSGeXu3AB2HJI9A==", null, false, "5472b3bd-f139-423f-a60c-1e57220f161f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(4722), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(4749), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5152), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5352), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5356), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5359), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5363), new DateTime(2025, 11, 28, 16, 7, 35, 73, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
