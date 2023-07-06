using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class AddEventAttendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventAttendances",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    RegistrationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendances", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventAttendances_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttendances_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 6, 19, 52, 12, 187, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_EventId",
                table: "EventAttendances",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAttendances");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 5, 20, 22, 26, 557, DateTimeKind.Utc).AddTicks(9055));
        }
    }
}
