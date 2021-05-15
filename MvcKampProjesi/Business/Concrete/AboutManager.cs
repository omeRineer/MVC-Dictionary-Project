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
    
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            ValidationTool.Load(new AboutRules(), about);



            _aboutDal.Add(about);
        }

        public void Delete(About about)
        {
            ValidationTool.Load(new AboutRules(), about);



            _aboutDal.Delete(about);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int aboutId)
        {
            return _aboutDal.Get(p => p.AboutId == aboutId);
        }

        public void Update(About about)
        {
            ValidationTool.Load(new AboutRules(), about);



            _aboutDal.Update(about);
        }
    }
}
