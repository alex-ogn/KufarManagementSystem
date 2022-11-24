using KufarManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KufarManagementSystem.Views.Models
{
    public class ApplicationUserModel: ApplicationUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Display(Name = "First name")]
        [Required]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }


        [Display(Name = "Starting date")]
        public DateTime StartingDate { get; set; }

        [Display(Name = "Is user active")]
        public bool ActiveUser { get; set; }

        [Display(Name = "Phone number")]
       // [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Telephone number number must consist of 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
