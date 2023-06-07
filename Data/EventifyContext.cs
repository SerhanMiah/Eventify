using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Data
{
    public class EventifyContext : IdentityDbContext<ApplicationUser> 
    {
        public EventifyContext(DbContextOptions<EventifyContext> options)
            : base(options)
        {
        }

        // Dbsets for the Event models
        public DbSet<Event> Events {get; set;}
        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Attendee> Attendees {get; set;}

        public DbSet<ApplicationUser> ApplicationUsers {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Event>()
                .Property(e => e.Category)
                .HasConversion<string>();

            modelBuilder
                .Entity<Ticket>()
                .Property(t => t.Price)
                .HasPrecision(18, 2);

            // Seeding Data - Events
           modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1, 
                    Name = "Tech Conference 2024", 
                    Description = "A tech conference with key speakers from around the world.", 
                    Date = new DateTime(2024, 10, 20), 
                    Location = "San Francisco", 
                    Organizer = "Tech Conferences Inc.", 
                    MaxAttendees = 500, 
                    Category = Category.Tech,
                    ImageUrl = "https://example.com/tech-conference.jpg",
                    IsOnline = false,
                    TicketLink = "https://techconferenceinc.com/tech-conference-2024"
                },
                new Event
                {
                    Id = 2,
                    Name = "AI Summit 2024",
                    Description = "A summit dedicated to artificial intelligence trends and advancements.",
                    Date = new DateTime(2024, 5, 15),
                    Location = "New York",
                    Organizer = "AI Events Ltd.",
                    MaxAttendees = 300,
                    Category = Category.Tech,
                    ImageUrl = "https://example.com/ai-summit.jpg",
                    IsOnline = true,
                    TicketLink = "https://aievents.com/ai-summit-2024"
                },
                new Event
                {
                    Id = 3,
                    Name = "Cybersecurity Workshop 2024",
                    Description = "A workshop focusing on the latest cybersecurity techniques.",
                    Date = new DateTime(2024, 8, 27),
                    Location = "Austin",
                    Organizer = "Cyber Events",
                    MaxAttendees = 100,
                    Category = Category.Tech,
                    ImageUrl = "https://example.com/cybersecurity-workshop.jpg",
                    IsOnline = false,
                    TicketLink = "https://cyberevents.com/cybersecurity-workshop-2024"
                },
                new Event
                {
                    Id = 4,
                    Name = "Cloud Computing Expo 2024",
                    Description = "An expo showcasing the latest in cloud computing technologies.",
                    Date = new DateTime(2024, 11, 12),
                    Location = "Seattle",
                    Organizer = "Cloud Events",
                    MaxAttendees = 700,
                    Category = Category.Tech,
                    ImageUrl = "https://example.com/cloud-computing-expo.jpg",
                    IsOnline = false,
                    TicketLink = "https://cloudevents.com/cloud-computing-expo-2024"
                },
                new Event
                {
                    Id = 5,
                    Name = "Data Science Fair 2024",
                    Description = "A fair displaying the most recent data science projects and studies.",
                    Date = new DateTime(2024, 4, 3),
                    Location = "Boston",
                    Organizer = "Data Science Org.",
                    MaxAttendees = 400,
                    Category = Category.Tech,
                    ImageUrl = "https://example.com/data-science-fair.jpg",
                    IsOnline = true,
                    TicketLink = "https://datascienceorg.com/data-science-fair-2024"
                }, 
                // seeding music
                new Event
                {
                    Id = 6,
                    Name = "Global Music Festival 2024",
                    Description = "A music festival featuring artists from around the world.",
                    Date = new DateTime(2024, 7, 10),
                    Location = "Los Angeles",
                    Organizer = "Music Events Inc.",
                    MaxAttendees = 10000,
                    Category = Category.Music,
                    ImageUrl = "https://example.com/global-music-festival.jpg",
                    IsOnline = false,
                    TicketLink = "https://musiceventsinc.com/global-music-festival-2024"
                },
                new Event
                {
                    Id = 7,
                    Name = "Virtual Concert Series 2024",
                    Description = "A series of concerts streamed live from various locations.",
                    Date = new DateTime(2024, 6, 15),
                    Location = "Online",
                    Organizer = "Virtual Concerts Ltd.",
                    MaxAttendees = 20000,
                    Category = Category.Music,
                    ImageUrl = "https://example.com/virtual-concert.jpg",
                    IsOnline = true,
                    TicketLink = "https://virtualconcerts.com/concert-series-2024"
                },
                new Event
                {
                    Id = 8,
                    Name = "Classical Music Gala 2024",
                    Description = "An evening of performances by renowned classical musicians.",
                    Date = new DateTime(2024, 11, 1),
                    Location = "New York",
                    Organizer = "Classical Events",
                    MaxAttendees = 500,
                    Category = Category.Music,
                    ImageUrl = "https://example.com/classical-music-gala.jpg",
                    IsOnline = false,
                    TicketLink = "https://classicalevents.com/music-gala-2024"
                },
                new Event
                {
                    Id = 9,
                    Name = "Indie Music Showcase 2024",
                    Description = "Showcase of the best indie music talent from across the globe.",
                    Date = new DateTime(2024, 8, 19),
                    Location = "London",
                    Organizer = "Indie Music Ltd.",
                    MaxAttendees = 800,
                    Category = Category.Music,
                    ImageUrl = "https://example.com/indie-music-showcase.jpg",
                    IsOnline = false,
                    TicketLink = "https://indiemusic.com/showcase-2024"
                },
                new Event
                {
                    Id = 10,
                    Name = "Rock and Roll Revival 2024",
                    Description = "A revival of the best rock and roll music from the 70s and 80s.",
                    Date = new DateTime(2024, 5, 28),
                    Location = "Chicago",
                    Organizer = "Rock Events",
                    MaxAttendees = 1500,
                    Category = Category.Music,
                    ImageUrl = "https://example.com/rock-and-roll-revival.jpg",
                    IsOnline = false,
                    TicketLink = "https://rockevents.com/revival-2024"
                },
                new Event
                // seeding football
                {
                    Id = 11,
                    Name = "Global Soccer Championship 2024",
                    Description = "A soccer championship featuring teams from around the world.",
                    Date = new DateTime(2024, 6, 1),
                    Location = "Madrid",
                    Organizer = "Soccer Events Inc.",
                    MaxAttendees = 80000,
                    Category = Category.Sports,
                    ImageUrl = "https://example.com/global-soccer-championship.jpg",
                    IsOnline = false,
                    TicketLink = "https://soccereventsinc.com/global-championship-2024"
                },
                new Event
                {
                    Id = 12,
                    Name = "Virtual Fitness Marathon 2024",
                    Description = "A virtual fitness marathon for fitness enthusiasts around the globe.",
                    Date = new DateTime(2024, 5, 10),
                    Location = "Online",
                    Organizer = "Fitness Events Ltd.",
                    MaxAttendees = 10000,
                    Category = Category.Sports,
                    ImageUrl = "https://example.com/virtual-fitness-marathon.jpg",
                    IsOnline = true,
                    TicketLink = "https://fitnessevents.com/marathon-2024"
                },
                new Event
                {
                    Id = 13,
                    Name = "International Tennis Open 2024",
                    Description = "A tennis tournament with international players.",
                    Date = new DateTime(2024, 8, 20),
                    Location = "Paris",
                    Organizer = "Tennis Events",
                    MaxAttendees = 20000,
                    Category = Category.Sports,
                    ImageUrl = "https://example.com/international-tennis-open.jpg",
                    IsOnline = false,
                    TicketLink = "https://tennisevents.com/open-2024"
                },
                new Event
                {
                    Id = 14,
                    Name = "Global Skateboarding Championship 2024",
                    Description = "Skateboarding championship featuring international talent.",
                    Date = new DateTime(2024, 7, 14),
                    Location = "Los Angeles",
                    Organizer = "Skateboarding Events Ltd.",
                    MaxAttendees = 5000,
                    Category = Category.Sports,
                    ImageUrl = "https://example.com/skateboarding-championship.jpg",
                    IsOnline = false,
                    TicketLink = "https://skateboardingevents.com/championship-2024"
                },
                new Event
                {
                    Id = 15,
                    Name = "International Swimming Gala 2024",
                    Description = "A gala featuring renowned international swimmers.",
                    Date = new DateTime(2024, 9, 10),
                    Location = "Sydney",
                    Organizer = "Swimming Events",
                    MaxAttendees = 8000,
                    Category = Category.Sports,
                    ImageUrl = "https://example.com/international-swimming-gala.jpg",
                    IsOnline = false,
                    TicketLink = "https://swimmingevents.com/gala-2024"
                },
                    new Event
                    // 5 seeding data family event
                {
                    Id = 16,
                    Name = "Virtual Homeschooling Seminar 2024",
                    Description = "A seminar on homeschooling, featuring experienced educators and parents.",
                    Date = new DateTime(2024, 5, 3),
                    Location = "Online",
                    Organizer = "Educational Events Ltd.",
                    MaxAttendees = 10000,
                    Category = Category.FamilyAndEducation,
                    ImageUrl = "https://example.com/homeschooling-seminar.jpg",
                    IsOnline = true,
                    TicketLink = "https://educationalevents.com/homeschooling-seminar"
                },
                new Event
                {
                    Id = 17,
                    Name = "International Science Fair 2024",
                    Description = "A science fair featuring projects from students around the globe.",
                    Date = new DateTime(2024, 6, 20),
                    Location = "New York",
                    Organizer = "Educational Events Inc.",
                    MaxAttendees = 2000,
                    Category = Category.FamilyAndEducation,
                    ImageUrl = "https://example.com/international-science-fair.jpg",
                    IsOnline = false,
                    TicketLink = "https://educationaleventsinc.com/science-fair-2024"
                },
                new Event
                {
                    Id = 18,
                    Name = "Virtual Parenting Workshop 2024",
                    Description = "A workshop on effective parenting strategies.",
                    Date = new DateTime(2024, 8, 10),
                    Location = "Online",
                    Organizer = "Family Events Ltd.",
                    MaxAttendees = 5000,
                    Category = Category.FamilyAndEducation,
                    ImageUrl = "https://example.com/parenting-workshop.jpg",
                    IsOnline = true,
                    TicketLink = "https://familyeventsltd.com/workshop-2024"
                },
                new Event
                {
                    Id = 19,
                    Name = "International Art Festival for Kids 2024",
                    Description = "An art festival for kids featuring art workshops and competitions.",
                    Date = new DateTime(2024, 7, 20),
                    Location = "Berlin",
                    Organizer = "Art Events Inc.",
                    MaxAttendees = 5000,
                    Category = Category.FamilyAndEducation,
                    ImageUrl = "https://example.com/art-festival-kids.jpg",
                    IsOnline = false,
                    TicketLink = "https://arteventsinc.com/festival-kids-2024"
                },
                new Event
                {
                    Id = 20,
                    Name = "Virtual Math Olympiad 2024",
                    Description = "An online math Olympiad for students worldwide.",
                    Date = new DateTime(2024, 9, 5),
                    Location = "Online",
                    Organizer = "Educational Events",
                    MaxAttendees = 10000,
                    Category = Category.FamilyAndEducation,
                    ImageUrl = "https://example.com/math-olympiad.jpg",
                    IsOnline = true,
                    TicketLink = "https://educationalevents.com/olympiad-2024"
                }
                // Seeding Data - Sports
                // Seeding Data - Education
                // Seeding Data - Gaming
                // Seeding Data - FamilyAndEducation
                
            );

            

        }


    }
}