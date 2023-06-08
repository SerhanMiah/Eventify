﻿// <auto-generated />
using System;
using Eventify.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eventify.Migrations
{
    [DbContext(typeof(EventifyContext))]
    partial class EventifyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eventify.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Eventify.Models.Attendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("Eventify.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaxAttendees")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Organizer")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TicketLink")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Tech",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4515),
                            Date = new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A tech conference with key speakers from around the world.",
                            ImageUrl = "https://images.squarespace-cdn.com/content/59eb6488d7bdceee681392c3/1680686199568-OWQ2U5JE93OYJTIDF7P2/CET+3+%282%29.png?format=1500w&content-type=image%2Fpng",
                            IsOnline = false,
                            Location = "San Francisco",
                            MaxAttendees = 500,
                            Name = "Tech Conference 2024",
                            Organizer = "Tech Conferences Inc.",
                            TicketLink = "https://techconferenceinc.com/tech-conference-2024"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Tech",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4523),
                            Date = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A summit dedicated to artificial intelligence trends and advancements.",
                            ImageUrl = "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F507564539%2F433439078672%2F1%2Foriginal.20230504-132036?w=1000&auto=format%2Ccompress&q=75&sharp=10&rect=0%2C52%2C1640%2C820&s=103e7a1a4466d09a5a882d09af11c698",
                            IsOnline = true,
                            Location = "New York",
                            MaxAttendees = 300,
                            Name = "AI Summit 2024",
                            Organizer = "AI Events Ltd.",
                            TicketLink = "https://aievents.com/ai-summit-2024"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Tech",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4526),
                            Date = new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A workshop focusing on the latest cybersecurity techniques.",
                            ImageUrl = "https://futurescot.com/wp-content/uploads/2023/02/CYBER-2024-thumbnail.png",
                            IsOnline = false,
                            Location = "Austin",
                            MaxAttendees = 100,
                            Name = "Cybersecurity Workshop 2024",
                            Organizer = "Cyber Events",
                            TicketLink = "https://cyberevents.com/cybersecurity-workshop-2024"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Tech",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4527),
                            Date = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An expo showcasing the latest in cloud computing technologies.",
                            ImageUrl = "https://www.showsbee.com/newmaker/www/u/2015/201511/cfr_img/Cloud-Expo-Europe.png",
                            IsOnline = false,
                            Location = "Seattle",
                            MaxAttendees = 700,
                            Name = "Cloud Computing Expo 2024",
                            Organizer = "Cloud Events",
                            TicketLink = "https://cloudevents.com/cloud-computing-expo-2024"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Tech",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4529),
                            Date = new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A fair displaying the most recent data science projects and studies.",
                            ImageUrl = "https://datainnovationsummit.com/wp-content/uploads/2023/05/DIS-24-link-preview.jpg",
                            IsOnline = true,
                            Location = "Boston",
                            MaxAttendees = 400,
                            Name = "Data Science Fair 2024",
                            Organizer = "Data Science Org.",
                            TicketLink = "https://datascienceorg.com/data-science-fair-2024"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Music",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4531),
                            Date = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A music festival featuring artists from around the world.",
                            ImageUrl = "https://nationaltoday.com/wp-content/uploads/2022/08/4568086-min.jpg.webp",
                            IsOnline = false,
                            Location = "Los Angeles",
                            MaxAttendees = 10000,
                            Name = "Global Music Festival 2024",
                            Organizer = "Music Events Inc.",
                            TicketLink = "https://musiceventsinc.com/global-music-festival-2024"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Music",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4532),
                            Date = new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A series of concerts streamed live from various locations.",
                            ImageUrl = "https://blog.siriusxm.com/wp-content/uploads/2022/02/22-5902_NxtWave_Vol4-1920x1080-1.jpg?w=940",
                            IsOnline = true,
                            Location = "Online",
                            MaxAttendees = 20000,
                            Name = "Virtual Concert Series 2024",
                            Organizer = "Virtual Concerts Ltd.",
                            TicketLink = "https://virtualconcerts.com/concert-series-2024"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Music",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4535),
                            Date = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An evening of performances by renowned classical musicians.",
                            ImageUrl = "https://www.icma-info.com/wp-content/uploads/2023/03/OV-A.-Liebreich.-Foto-Live-Music-Valencia-red.jpg",
                            IsOnline = false,
                            Location = "New York",
                            MaxAttendees = 500,
                            Name = "Classical Music Gala 2024",
                            Organizer = "Classical Events",
                            TicketLink = "https://classicalevents.com/music-gala-2024"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Music",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4537),
                            Date = new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Showcase of the best indie music talent from across the globe.",
                            ImageUrl = "https://d31fr2pwly4c4s.cloudfront.net/3/b/9/1549401_59b37172_revival-music-festival-weekender-2024_1024.jpg",
                            IsOnline = false,
                            Location = "London",
                            MaxAttendees = 800,
                            Name = "Indie Music Showcase 2024",
                            Organizer = "Indie Music Ltd.",
                            TicketLink = "https://indiemusic.com/showcase-2024"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Music",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4539),
                            Date = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A revival of the best rock and roll music from the 70s and 80s.",
                            ImageUrl = "https://d31fr2pwly4c4s.cloudfront.net/3/b/9/1549401_59b37172_revival-music-festival-weekender-2024_1024.jpg",
                            IsOnline = false,
                            Location = "Chicago",
                            MaxAttendees = 1500,
                            Name = "Rock and Roll Revival 2024",
                            Organizer = "Rock Events",
                            TicketLink = "https://rockevents.com/revival-2024"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Sports",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4541),
                            Date = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A soccer championship featuring teams from around the world.",
                            ImageUrl = "https://digitalhub.fifa.com/transform/b4d0cf3d-795e-438c-9b59-753a030d2e24/Olympics-Paris-2024-Logo",
                            IsOnline = false,
                            Location = "Madrid",
                            MaxAttendees = 80000,
                            Name = "Global Soccer Championship 2024",
                            Organizer = "Soccer Events Inc.",
                            TicketLink = "https://soccereventsinc.com/global-championship-2024"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Sports",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4543),
                            Date = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A virtual fitness marathon for fitness enthusiasts around the globe.",
                            ImageUrl = "https://www.getkidsgoing.com/wp-install/wp-content/uploads/2021/02/virtual-tcs-london-marathon-run-for-get-kids-going-scaled.jpg",
                            IsOnline = true,
                            Location = "Online",
                            MaxAttendees = 10000,
                            Name = "Virtual Fitness Marathon 2024",
                            Organizer = "Fitness Events Ltd.",
                            TicketLink = "https://fitnessevents.com/marathon-2024"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Sports",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4545),
                            Date = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A tennis tournament with international players.",
                            ImageUrl = "https://www.tennistours.com/img/tournament-images/miami-open-index.jpg",
                            IsOnline = false,
                            Location = "Paris",
                            MaxAttendees = 20000,
                            Name = "International Tennis Open 2024",
                            Organizer = "Tennis Events",
                            TicketLink = "https://tennisevents.com/open-2024"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Sports",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4546),
                            Date = new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Skateboarding championship featuring international talent.",
                            ImageUrl = "https://cdn.dmcl.biz/media/image/239182/o/momiji+nishiya.jpg",
                            IsOnline = false,
                            Location = "Los Angeles",
                            MaxAttendees = 5000,
                            Name = "Global Skateboarding Championship 2024",
                            Organizer = "Skateboarding Events Ltd.",
                            TicketLink = "https://skateboardingevents.com/championship-2024"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Sports",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4548),
                            Date = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A gala featuring renowned international swimmers.",
                            ImageUrl = "https://medias.paris2024.org/uploads/2020/11/1331557859-scaled.jpeg?x-oss-process=image/resize,w_2560,h_1707,m_lfit/format,jpeg",
                            IsOnline = false,
                            Location = "Sydney",
                            MaxAttendees = 8000,
                            Name = "International Swimming Gala 2024",
                            Organizer = "Swimming Events",
                            TicketLink = "https://swimmingevents.com/gala-2024"
                        },
                        new
                        {
                            Id = 16,
                            Category = "FamilyAndEducation",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4549),
                            Date = new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A seminar on homeschooling, featuring experienced educators and parents.",
                            ImageUrl = "https://navsh.org.uk/source/logo.png",
                            IsOnline = true,
                            Location = "Online",
                            MaxAttendees = 10000,
                            Name = "Virtual Homeschooling Seminar 2024",
                            Organizer = "Educational Events Ltd.",
                            TicketLink = "https://educationalevents.com/homeschooling-seminar"
                        },
                        new
                        {
                            Id = 17,
                            Category = "FamilyAndEducation",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4551),
                            Date = new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A science fair featuring projects from students around the globe.",
                            ImageUrl = "https://www.science-on-stage.eu/sites/default/files/images/ws22024_sons2024_banner_website.png",
                            IsOnline = false,
                            Location = "New York",
                            MaxAttendees = 2000,
                            Name = "International Science Fair 2024",
                            Organizer = "Educational Events Inc.",
                            TicketLink = "https://educationaleventsinc.com/science-fair-2024"
                        },
                        new
                        {
                            Id = 18,
                            Category = "FamilyAndEducation",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4552),
                            Date = new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A workshop on effective parenting strategies.",
                            ImageUrl = "https://cdn-az.allevents.in/events5/banners/dc4c7886d025f6489c11418c2842bfcc1c620f6b06846a3c5d347df0a9eb13bc-rimg-w1200-h600-gmir.jpg?v=1684632258",
                            IsOnline = true,
                            Location = "Online",
                            MaxAttendees = 5000,
                            Name = "Virtual Parenting Workshop 2024",
                            Organizer = "Family Events Ltd.",
                            TicketLink = "https://familyeventsltd.com/workshop-2024"
                        },
                        new
                        {
                            Id = 19,
                            Category = "FamilyAndEducation",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4554),
                            Date = new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An art festival for kids featuring art workshops and competitions.",
                            ImageUrl = "https://www.infodesigners.eu/immagine_copia/Art-On-Climate-Illustration-Competition-2023.png",
                            IsOnline = false,
                            Location = "Berlin",
                            MaxAttendees = 5000,
                            Name = "International Art Festival for Kids 2024",
                            Organizer = "Art Events Inc.",
                            TicketLink = "https://arteventsinc.com/festival-kids-2024"
                        },
                        new
                        {
                            Id = 20,
                            Category = "FamilyAndEducation",
                            CreatedAt = new DateTime(2023, 6, 8, 7, 41, 33, 669, DateTimeKind.Utc).AddTicks(4555),
                            Date = new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An online math Olympiad for students worldwide.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/IMO_logo.svg/1200px-IMO_logo.svg.png",
                            IsOnline = true,
                            Location = "Online",
                            MaxAttendees = 10000,
                            Name = "Virtual Math Olympiad 2024",
                            Organizer = "Educational Events",
                            TicketLink = "https://educationalevents.com/olympiad-2024"
                        });
                });

            modelBuilder.Entity("Eventify.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AttendeeEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AttendeeId")
                        .HasColumnType("int");

                    b.Property<string>("AttendeeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Eventify.Models.Attendee", b =>
                {
                    b.HasOne("Eventify.Models.Event", null)
                        .WithMany("Attendees")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("Eventify.Models.Ticket", b =>
                {
                    b.HasOne("Eventify.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Eventify.Models.Attendee", null)
                        .WithMany("Tickets")
                        .HasForeignKey("AttendeeId");

                    b.HasOne("Eventify.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Eventify.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Eventify.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Eventify.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Eventify.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Eventify.Models.Attendee", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Eventify.Models.Event", b =>
                {
                    b.Navigation("Attendees");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
