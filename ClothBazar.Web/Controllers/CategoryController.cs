using CloathBazar.Services;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        // Creating the object for the CategoryService class(ClothBazar.Services).
        CategoryService categoryService = new CategoryService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
            //  above line of code and below line of code both are same only.
            //  List<Category> categoriess = categoryService.GetCategories();
            return View(categories);
        }

        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
            //  return View();
            return RedirectToAction("Index");
        }

        // EDIT METHOD for Get and Update
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var category = categoryService.GetCategory(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            // Once the changes are updated we are navigating to the Index action  method in the same controller
            return RedirectToAction("Index");
        }


        //Delete Logic:
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            // var category = categoryService.GetCategory(ID);
            categoryService.DeletteCateory(category.ID);
            return RedirectToAction("Index");
        }
    }
}