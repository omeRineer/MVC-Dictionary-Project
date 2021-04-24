using Business.Abstract;
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
            
        }

        public void Delete(About about)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            throw new NotImplementedException();
        }

        public About GetById(int aboutId)
        {
            throw new NotImplementedException();
        }

        public void Update(About about)
        {
            throw new NotImplementedException();
        }
    }
}
