using System.ComponentModel.DataAnnotations;

namespace Workshop.Web.Models.ViewModels
{
    public class RegisterWorkerViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Type { get; set; }

        public string EnterTime { get; set; }
        public string LeaveTime { get; set; }

    }
}
