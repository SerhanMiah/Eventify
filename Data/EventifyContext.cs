using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventify.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Data
{
    public class EventifyContext : DbContext 
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
            modelBuilder
                .Entity<Event>()
                .Property(e => e.Category)
                .HasConversion<string>();

            modelBuilder
                .Entity<Ticket>()
                .Property(t => t.Price)
                .HasPrecision(18, 2);
        }


    }
}