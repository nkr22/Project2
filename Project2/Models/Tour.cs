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
        public string GroupName { get; set; }

        [Required]
        [Range(1, 15)]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required]
        // Build Foreign Key Relationship with Time
        public int SlotId { get; set; }
        public Time Slot { get; set; }
    }
}
