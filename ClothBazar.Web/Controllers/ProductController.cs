using CloathBazar.Services;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService prodService = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)
        {
            //This line of code is to access all the products.
            var prods = prodService.GetProducts();

            //This will give only matching records information.
            if (string.IsNullOrEmpty(search) == false)
            {
                prods = prods.Where(p => p.Name!=null&&p.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(prods);
        }
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            prodService.SaveProduct(product);
            //  return View();
            return RedirectToAction("ProductTable");
        }

    }
}