using Business.Abstract;
using Business.ValidationRules;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            ValidationTool.Load(new CategoryRules(), category);



            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            



            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetByFalseStatus()
        {
            return _categoryDal.GetAll(x => x.CategoryStatus == false);
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(p => p.CategoryId == categoryId);
        }

        public List<Category> GetByTrueStatus()
        {
            return _categoryDal.GetAll(x => x.CategoryStatus == true);
        }

        public void Update(Category category)
        {
            //ValidationTool.Load(new CategoryRules(), category);



            _categoryDal.Update(category);
        }
    }
}
