using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Nidly.Models;


namespace Nidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomer();

            return View(customers);
            
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c =>c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Harry Potter"},
                new Customer { Id =2, Name = "Khushboo Singh" }

            };
                
        }        
    }
}
    