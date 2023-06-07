using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eventify.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Organizer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxAttendees = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    TicketLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendees_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    AttendeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendeeEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AttendeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Attendees_AttendeeId",
                        column: x => x.AttendeeId,
                        principalTable: "Attendees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "CreatedAt", "Date", "Description", "ImageUrl", "IsOnline", "Location", "MaxAttendees", "Name", "Organizer", "TicketLink", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Tech", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A tech conference with key speakers from around the world.", "https://example.com/tech-conference.jpg", false, "San Francisco", 500, "Tech Conference 2024", "Tech Conferences Inc.", "https://techconferenceinc.com/tech-conference-2024", null },
                    { 2, "Tech", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A summit dedicated to artificial intelligence trends and advancements.", "https://example.com/ai-summit.jpg", true, "New York", 300, "AI Summit 2024", "AI Events Ltd.", "https://aievents.com/ai-summit-2024", null },
                    { 3, "Tech", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A workshop focusing on the latest cybersecurity techniques.", "https://example.com/cybersecurity-workshop.jpg", false, "Austin", 100, "Cybersecurity Workshop 2024", "Cyber Events", "https://cyberevents.com/cybersecurity-workshop-2024", null },
                    { 4, "Tech", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "An expo showcasing the latest in cloud computing technologies.", "https://example.com/cloud-computing-expo.jpg", false, "Seattle", 700, "Cloud Computing Expo 2024", "Cloud Events", "https://cloudevents.com/cloud-computing-expo-2024", null },
                    { 5, "Tech", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fair displaying the most recent data science projects and studies.", "https://example.com/data-science-fair.jpg", true, "Boston", 400, "Data Science Fair 2024", "Data Science Org.", "https://datascienceorg.com/data-science-fair-2024", null },
                    { 6, "Music", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A music festival featuring artists from around the world.", "https://example.com/global-music-festival.jpg", false, "Los Angeles", 10000, "Global Music Festival 2024", "Music Events Inc.", "https://musiceventsinc.com/global-music-festival-2024", null },
                    { 7, "Music", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A series of concerts streamed live from various locations.", "https://example.com/virtual-concert.jpg", true, "Online", 20000, "Virtual Concert Series 2024", "Virtual Concerts Ltd.", "https://virtualconcerts.com/concert-series-2024", null },
                    { 8, "Music", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An evening of performances by renowned classical musicians.", "https://example.com/classical-music-gala.jpg", false, "New York", 500, "Classical Music Gala 2024", "Classical Events", "https://classicalevents.com/music-gala-2024", null },
                    { 9, "Music", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Showcase of the best indie music talent from across the globe.", "https://example.com/indie-music-showcase.jpg", false, "London", 800, "Indie Music Showcase 2024", "Indie Music Ltd.", "https://indiemusic.com/showcase-2024", null },
                    { 10, "Music", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A revival of the best rock and roll music from the 70s and 80s.", "https://example.com/rock-and-roll-revival.jpg", false, "Chicago", 1500, "Rock and Roll Revival 2024", "Rock Events", "https://rockevents.com/revival-2024", null },
                    { 11, "Sports", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A soccer championship featuring teams from around the world.", "https://example.com/global-soccer-championship.jpg", false, "Madrid", 80000, "Global Soccer Championship 2024", "Soccer Events Inc.", "https://soccereventsinc.com/global-championship-2024", null },
                    { 12, "Sports", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9425), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A virtual fitness marathon for fitness enthusiasts around the globe.", "https://example.com/virtual-fitness-marathon.jpg", true, "Online", 10000, "Virtual Fitness Marathon 2024", "Fitness Events Ltd.", "https://fitnessevents.com/marathon-2024", null },
                    { 13, "Sports", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A tennis tournament with international players.", "https://example.com/international-tennis-open.jpg", false, "Paris", 20000, "International Tennis Open 2024", "Tennis Events", "https://tennisevents.com/open-2024", null },
                    { 14, "Sports", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skateboarding championship featuring international talent.", "https://example.com/skateboarding-championship.jpg", false, "Los Angeles", 5000, "Global Skateboarding Championship 2024", "Skateboarding Events Ltd.", "https://skateboardingevents.com/championship-2024", null },
                    { 15, "Sports", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gala featuring renowned international swimmers.", "https://example.com/international-swimming-gala.jpg", false, "Sydney", 8000, "International Swimming Gala 2024", "Swimming Events", "https://swimmingevents.com/gala-2024", null },
                    { 16, "FamilyAndEducation", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9432), new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seminar on homeschooling, featuring experienced educators and parents.", "https://example.com/homeschooling-seminar.jpg", true, "Online", 10000, "Virtual Homeschooling Seminar 2024", "Educational Events Ltd.", "https://educationalevents.com/homeschooling-seminar", null },
                    { 17, "FamilyAndEducation", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9434), new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A science fair featuring projects from students around the globe.", "https://example.com/international-science-fair.jpg", false, "New York", 2000, "International Science Fair 2024", "Educational Events Inc.", "https://educationaleventsinc.com/science-fair-2024", null },
                    { 18, "FamilyAndEducation", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9435), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A workshop on effective parenting strategies.", "https://example.com/parenting-workshop.jpg", true, "Online", 5000, "Virtual Parenting Workshop 2024", "Family Events Ltd.", "https://familyeventsltd.com/workshop-2024", null },
                    { 19, "FamilyAndEducation", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9437), new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "An art festival for kids featuring art workshops and competitions.", "https://example.com/art-festival-kids.jpg", false, "Berlin", 5000, "International Art Festival for Kids 2024", "Art Events Inc.", "https://arteventsinc.com/festival-kids-2024", null },
                    { 20, "FamilyAndEducation", new DateTime(2023, 6, 7, 17, 4, 18, 132, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "An online math Olympiad for students worldwide.", "https://example.com/math-olympiad.jpg", true, "Online", 10000, "Virtual Math Olympiad 2024", "Educational Events", "https://educationalevents.com/olympiad-2024", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_EventId",
                table: "Attendees",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ApplicationUserId",
                table: "Tickets",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AttendeeId",
                table: "Tickets",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
