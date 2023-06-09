using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class AddEnumToStringConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 20, 49, 550, DateTimeKind.Utc).AddTicks(3188));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4555));
        }
    }
}
