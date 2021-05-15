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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            ValidationTool.Load(new WriterRules(), writer);



            _writerDal.Add(writer);
        }

        public void Delete(Writer writer)
        {
            ValidationTool.Load(new WriterRules(), writer);



            _writerDal.Delete(writer);
        }

        public List<Writer> GetAll()
        {
            return _writerDal.GetAll();
        }

        public Writer GetById(int writerId)
        {
            return _writerDal.Get(p => p.WriterId == writerId);
        }

        public List<Writer> GetWriterByStartA()
        {
            return _writerDal.GetAll(x => x.WriterName.Contains("a"));
        }

        public void Update(Writer writer)
        {
            ValidationTool.Load(new WriterRules(), writer);



            _writerDal.Update(writer);
        }
    }
}
