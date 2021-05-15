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
    public class ContactManager : IContactService
    {
        IContactDal _contacDal;

        public ContactManager(IContactDal contacDal)
        {
            _contacDal = contacDal;
        }

        public void Add(Contact contact)
        {
            ValidationTool.Load(new ContactRules(), contact);



            _contacDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            ValidationTool.Load(new ContactRules(), contact);



            _contacDal.Delete(contact);
        }

        public List<Contact> GetAll()
        {
            return _contacDal.GetAll();
        }

        public Contact GetById(int contactId)
        {
            return _contacDal.Get(p => p.ContactId == contactId);
        }

        public void Update(Contact contact)
        {
            ValidationTool.Load(new ContactRules(), contact);



            _contacDal.Update(contact);
        }
    }
}
