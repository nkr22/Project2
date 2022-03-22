using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Tour
    {
        [Key]
        [Required]
        public int TourId { get; set; }

        [Required]
        // Build Foreign Key Relationship with Time
        public int SlotId { get; set; }
        public Time Slot { get; set; }

        [Required]
        // Builds Foreign Key Relationship with Contact Info
        public int GroupId { get; set; }
        public ContactInfo Group { get; set; }
    }
}
