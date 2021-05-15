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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void Add(Heading heading)
        {
            ValidationTool.Load(new HeadingRules(), heading);



            _headingDal.Add(heading);
        }

        public void Delete(Heading heading)
        {
            ValidationTool.Load(new HeadingRules(), heading);



            _headingDal.Delete(heading);
        }

        public List<Heading> GetAll()
        {
            return _headingDal.GetAll();
        }

        public List<Heading> GetByCategory(int categoryId)
        {
            return _headingDal.GetAll(x => x.CategoryId == categoryId);
        }

        public Heading GetById(int headingId)
        {
            return _headingDal.Get(p => p.HeadingId == headingId);
        }

        public void Update(Heading heading)
        {
            ValidationTool.Load(new HeadingRules(), heading);



            _headingDal.Update(heading);
        }
    }
}
