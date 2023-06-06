using System;
using System.ComponentModel.DataAnnotations;

namespace Eventify.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; } 

        public Event Event { get; set; }  

        [Required]
        [StringLength(50)]
        public string AttendeeName { get; set; }  

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string AttendeeEmail { get; set; }  

        [Required]
        [Range(0, 99999.99)]  
        public decimal Price { get; set; }  

        [Required]
        public DateTime PurchaseDate { get; set; }  
    }
}
