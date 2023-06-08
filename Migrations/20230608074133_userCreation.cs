using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class userCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 20, 46, 31, 474, DateTimeKind.Utc).AddTicks(9733));
        }
    }
}
