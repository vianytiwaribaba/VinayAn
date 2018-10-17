using CloothBazar.Entities;
using CloothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAnuv.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesServices CategoryService = new CategoriesServices();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = CategoryService.GetCategories();

            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            CategoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = CategoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            CategoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = CategoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            category = CategoryService.GetCategory(category.ID);

            CategoryService.DelectCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}