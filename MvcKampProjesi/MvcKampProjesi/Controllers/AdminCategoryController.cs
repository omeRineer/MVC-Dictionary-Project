using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKampProjesi.Controllers
{
    public class AdminCategoryController : Controller
    {
        ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Index");
        }

        
        public ActionResult DeleteCategory(int id)
        {
            var category = _categoryService.GetById(id);
            _categoryService.Delete(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = _categoryService.GetById(id);
            return View(category);
            
        }

         [HttpPost]
         public ActionResult UpdateCategory(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction("Index");
        }
    }
}