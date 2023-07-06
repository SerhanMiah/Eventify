using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eventify.Models
{
    public enum Category
    {
        Music,
        Sports,
        Education,
        Business,
        Tech,
        Health,
        Science,
        Travel,
        FoodAndDrink,
        Art,
        Fashion,
        FilmAndMedia,
        Charity,
        Community,
        Environment,
        Politics,
        Spiritual,
        FamilyAndEducation,
        AutoBoatAndAir,
        Hobbies,
        HomeAndLifestyle,
        Holiday,
        Government,
        Gaming,
        Other 
    }

    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; } 

        [Required]
        public DateTime Date { get; set; } 

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(100)]
        public string? Organizer { get; set; } 

        [Required]
        public int MaxAttendees { get; set; } 

        public Category Category { get; set; }

        [StringLength(500)]
        public string? ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsOnline { get; set; } // To distinguish between online and physical events

        [StringLength(500)]
        public string? TicketLink { get; set; } // External link to buy tickets

        public ICollection<Ticket>? Tickets { get; set; } // List of tickets associated with this event

        public ICollection<Attendee>? Attendees { get; set; } // List of attendees for this event

        public ICollection<EventAttendance> EventAttendances { get; set; }

    }
}
