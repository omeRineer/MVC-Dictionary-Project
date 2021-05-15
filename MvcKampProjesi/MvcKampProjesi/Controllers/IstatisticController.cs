using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKampProjesi.Controllers
{
    public class IstatisticController : Controller
    {
        ICategoryService categoryService = new CategoryManager(new EfCategoryDal());
        IHeadingService headingService = new HeadingManager(new EfHeadingDal());
        IWriterService writerService = new WriterManager(new EfWriterDal());
        // GET: Istatistic
        public ActionResult Index()
        {
            int categoryCount = categoryService.GetAll().Count;
            int yazilimHeading = headingService.GetByCategory(9).Count;
            int yazara = writerService.GetWriterByStartA().Count;
            int trueFalse = categoryService.GetByTrueStatus().Count - categoryService.GetByFalseStatus().Count;
            ViewBag.CategoryCount = categoryCount;
            ViewBag.YazilimHeading = yazilimHeading;
            ViewBag.YazarA = yazara;
            ViewBag.TrueFalse = trueFalse;
            return View();
        }
    }
}