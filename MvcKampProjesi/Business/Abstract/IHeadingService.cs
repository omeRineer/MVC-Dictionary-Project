using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetAll();
        List<Heading> GetByCategory(int categoryId);
        Heading GetById(int headingId);

        void Add(Heading heading);
        void Delete(Heading heading);
        void Update(Heading heading);
    }
}
