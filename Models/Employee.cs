using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int EmployeeId { get; set; }

    }
}
