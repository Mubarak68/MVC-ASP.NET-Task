using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
       static List<Employee> employeeList =
     [
         new Employee()
            {EmployeeId = 89889,
            FirstName = "Mubarak",
            LastName = "Aloraifan",
            Email = "mto@gmail.com",
            Department = "IT"},
            new Employee()
            {EmployeeId = 88121,
            FirstName = "Ahmad",
            LastName = "Almusallam",
            Email = "aym@gmail.com",
            Department = "IT Governce"},
            new Employee()
            {EmployeeId = 89881,
            FirstName = "Abdullah",
            LastName = "Bin Essa",
            Email = "aeb@gmail.com",
            Department = "Call Center"}

     ];
        public IActionResult Index()
        {
            return View(employeeList);
        }
        public IActionResult Details(int id)
        {
            var employees = employeeList.SingleOrDefault(a => a.EmployeeId == id);
            if (employees == null)
            {
                return RedirectToAction("Index");
            }
            return View(employees);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection form)
        {
            var firstName = form["FirstName"];
            var lastName = form["LastName"];
            var email = form["Email"];
            var department = form["Department"];

            employeeList.Add(new Employee() { 
                FirstName = firstName, 
                LastName = lastName,
                Email = email, 
                Department = department });
            return RedirectToAction("Index");
        }


    }
}
