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
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            
        }

        public CategoryController()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return View();
        }
    }
}