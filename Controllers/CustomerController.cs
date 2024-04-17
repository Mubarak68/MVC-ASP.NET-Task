using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
       
            List<Customer> customerList = 
            [
                new Customer() { CustomerCivilId = 1,
                CustomerName = "Mubarak",
                CustomerPhone = 6672677,
                CustomerEmail = "892s@hgdd.com"},
                new Customer() { CustomerCivilId = 2,
                CustomerName = "Ahmad",
                CustomerPhone = 9909922,
                CustomerEmail = "83344@dsgdf.com"},
                new Customer() { CustomerCivilId = 3,
                CustomerName = "Saleh",
                CustomerPhone = 90099887,
                CustomerEmail = "83389@sfrwfwe.com"}
           ];
        public IActionResult Index()
        {
            return View(customerList);
        }
        public IActionResult Details(int id)
        {
            var customer = customerList.SingleOrDefault(a => a.CustomerCivilId == id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }


}
