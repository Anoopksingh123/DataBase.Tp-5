using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase.Tp_5.Models;


namespace DataBase.Tp_5.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = DbContext.Location.ToList();
            return View(locations);
        }
        public IActionResult CustomerList()
        {
            List<Customer> customers = DbContext.Customer.ToList();
            return View(customers);
        }
    }
}
