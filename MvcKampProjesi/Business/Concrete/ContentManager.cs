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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content content)
        {
            ValidationTool.Load(new ContentRules(), content);



            _contentDal.Add(content);
        }

        public void Delete(Content content)
        {
            ValidationTool.Load(new ContentRules(), content);



            _contentDal.Delete(content);
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetAll();
        }

        public Content GetById(int contentId)
        {
            return _contentDal.Get(p => p.ContentId == contentId);
        }

        public void Update(Content content)
        {
            ValidationTool.Load(new ContentRules(), content);



            _contentDal.Update(content);
        }
    }
}
