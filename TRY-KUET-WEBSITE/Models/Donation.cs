using System;
using System.ComponentModel.DataAnnotations;

namespace TRY_KUET_WEBSITE.Models
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a donation type")]
        public string DonationType { get; set; } = string.Empty; // "Blood", "Money", "Clothing"

        [Required(ErrorMessage = "Contact information is required")]
        public string ContactNumber { get; set; } = string.Empty;

        public string Details { get; set; } = string.Empty; // e.g., Blood Group or Amount in BDT

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
