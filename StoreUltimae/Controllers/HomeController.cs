using StoreUltimae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreUltimae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products()
        {// create more products

            /* var products = new List<string>();
               for (int i = 1; i <= 10; i++)
            {
                products.Add("Products"+ i.ToString());
}
            // pass mock products to view  for the display
            ViewBag.Products = products;*/
            var products = new List<Product>();

            for (int i = 1; i <= 10; i++)
            {

                Product product = new Product();

                product.name = "Product" + i.ToString();
                products.Add(product);
            }
            // load the view and pass the data 
            return View(products);

        }
        public ActionResult ViewProduct(string ProductName)
        {

            ViewBag.ProductName = ProductName
            return View();
        }

    }

}