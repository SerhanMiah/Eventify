using Eventify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
                    ImageUrl = "https://images.squarespace-cdn.com/content/59eb6488d7bdceee681392c3/1680686199568-OWQ2U5JE93OYJTIDF7P2/CET+3+%282%29.png?format=1500w&content-type=image%2Fpng",
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
                    ImageUrl = "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F507564539%2F433439078672%2F1%2Foriginal.20230504-132036?w=1000&auto=format%2Ccompress&q=75&sharp=10&rect=0%2C52%2C1640%2C820&s=103e7a1a4466d09a5a882d09af11c698",
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
                    ImageUrl = "https://futurescot.com/wp-content/uploads/2023/02/CYBER-2024-thumbnail.png",
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
                    ImageUrl = "https://www.showsbee.com/newmaker/www/u/2015/201511/cfr_img/Cloud-Expo-Europe.png",
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
                    ImageUrl = "https://datainnovationsummit.com/wp-content/uploads/2023/05/DIS-24-link-preview.jpg",
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
                    ImageUrl = "https://nationaltoday.com/wp-content/uploads/2022/08/4568086-min.jpg.webp",
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
                    ImageUrl = "https://blog.siriusxm.com/wp-content/uploads/2022/02/22-5902_NxtWave_Vol4-1920x1080-1.jpg?w=940",
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
                    ImageUrl = "https://www.icma-info.com/wp-content/uploads/2023/03/OV-A.-Liebreich.-Foto-Live-Music-Valencia-red.jpg",
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
                    ImageUrl = "https://d31fr2pwly4c4s.cloudfront.net/3/b/9/1549401_59b37172_revival-music-festival-weekender-2024_1024.jpg",
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
                    ImageUrl = "https://d31fr2pwly4c4s.cloudfront.net/3/b/9/1549401_59b37172_revival-music-festival-weekender-2024_1024.jpg",
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
                    ImageUrl = "https://digitalhub.fifa.com/transform/b4d0cf3d-795e-438c-9b59-753a030d2e24/Olympics-Paris-2024-Logo",
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
                    ImageUrl = "https://www.getkidsgoing.com/wp-install/wp-content/uploads/2021/02/virtual-tcs-london-marathon-run-for-get-kids-going-scaled.jpg",
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
                    ImageUrl = "https://www.tennistours.com/img/tournament-images/miami-open-index.jpg",
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
                    ImageUrl = "https://cdn.dmcl.biz/media/image/239182/o/momiji+nishiya.jpg",
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
                    ImageUrl = "https://medias.paris2024.org/uploads/2020/11/1331557859-scaled.jpeg?x-oss-process=image/resize,w_2560,h_1707,m_lfit/format,jpeg",
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
                    ImageUrl = "https://navsh.org.uk/source/logo.png",
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
                    ImageUrl = "https://www.science-on-stage.eu/sites/default/files/images/ws22024_sons2024_banner_website.png",
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
                    ImageUrl = "https://cdn-az.allevents.in/events5/banners/dc4c7886d025f6489c11418c2842bfcc1c620f6b06846a3c5d347df0a9eb13bc-rimg-w1200-h600-gmir.jpg?v=1684632258",
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
                    ImageUrl = "https://www.infodesigners.eu/immagine_copia/Art-On-Climate-Illustration-Competition-2023.png",
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
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/IMO_logo.svg/1200px-IMO_logo.svg.png",
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