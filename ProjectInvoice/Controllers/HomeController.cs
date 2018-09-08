using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectInvoice.Models;
using ProjectInvoice.DAL;



namespace ProjectInvoice.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataConnect _context;
        public HomeController(DataConnect context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            int hours = DateTime.Today.Hour;
            ViewBag.Greeting = hours < 12 ? "Good Morning" : "Good Afternoon";
            return View("SiteView");
        }
        public ActionResult ProductList()
        {

            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1001, Name = "Iphone", Price = 500, Image = "iphone.jpg" });
            products.Add(new Product() { Id = 2001, Name = "Iwatch", Price = 450, Image = "iwatch.jpg" });
            products.Add(new Product() { Id = 3001, Name = "Lg Phone", Price = 450, Image = "lg.jpg" });
            products.Add(new Product() { Id = 4001, Name = "Samsung Phone", Price = 450, Image = "samsung.jpg" });
            products.Add(new Product() { Id = 5001, Name = "Sony Phone", Price = 450, Image = "sony.jpg" });
            ViewBag.Products = products;
            return View();
        }
      
        public ActionResult CustomerDetailsForm()
        {
           return View();
        }
        [HttpPost]
        public ActionResult CustomerDetailsForm(CustomerDetails Customer)
        {
            _context.Add(Customer);
            _context.SaveChanges();
            return View();
        
         }

        public ActionResult SampleInvoice()
        {
         
            return View(_context.CustomerDetailss.Last());
              
        }
        
    }
}
