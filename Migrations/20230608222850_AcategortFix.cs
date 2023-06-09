using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class AcategortFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 22, 28, 50, 546, DateTimeKind.Utc).AddTicks(7625));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
