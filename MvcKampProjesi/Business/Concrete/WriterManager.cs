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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            
        }

        public void Delete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int writerId)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
