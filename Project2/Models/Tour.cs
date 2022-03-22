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
        // Build Foreign Key Relationship
        public int SlotId { get; set; }
        //BUILD MODEL FIRST
        public Times Slot { get; set; }

        [Required]
        public int GroupId { get; set; }
        public ContactInfo Group { get; set; }
    }
}
