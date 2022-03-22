using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public partial class ContactInfo
    {
        [Key]
        [Required]
        public int GroupId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
    }
}
