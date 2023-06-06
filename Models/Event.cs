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
    // Add other categories as needed
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
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
        public DateTime? UpdatedAt { get; set; }
    }
}
