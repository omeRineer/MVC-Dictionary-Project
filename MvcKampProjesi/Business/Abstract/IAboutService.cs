using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        About GetById(int aboutId);

        void Add(About about);
        void Delete(About about);
        void Update(About about);
    }
}
