using CloothBazar.Entities;
using CloothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAnuv.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productServices = new ProductServices();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productServices.GetProduct();

            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(P => P.Name != null && P.Name.ToLower().Contains(search.ToLower())).ToList();

            }
           
            return  PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productServices.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productServices.GetProduct(ID);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productServices.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productServices.DeleteProduct(ID);

            return RedirectToAction("ProductTable");
        }
    }
}