using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int SlotId {get; set;}

        [Required]
        public string Month { get; set; }

        [Required]
        public int Day { get; set; }

        [Required]
        public string Times { get; set; }

        public bool Filled { get; set; } = false;
    }
}
