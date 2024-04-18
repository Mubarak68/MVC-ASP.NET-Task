using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class EmployeeForm
    {
        [Required(ErrorMessage ="First Name is Missing")]
        [Display(Name ="First Name:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Missing")]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage ="There is something missing")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Add a Department name")]
        [Display(Name = "Department:")]
        public string Department { get; set; }
    }
}
