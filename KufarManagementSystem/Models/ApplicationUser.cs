using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KufarManagementSystem.Models
{
    public enum Gender { Male, Female, Other };

    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First name")]
        [Required]
        [Column]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        [Column]
        public string MiddleName { get; set; }

        [Display(Name = "Last  name")]
        [Required]
        [Column]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        [Column]
        public Gender Gender { get; set; }

        // TODO Split
        [Display(Name = "Address")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Column]
        public string Address { get; set; }

        [Display(Name = "Day of birth")]
        [Required]
        [Column]
        public DateTime DayOfBirth { get; set; }

    }

}
