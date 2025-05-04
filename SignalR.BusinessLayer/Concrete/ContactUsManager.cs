using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;
        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }
        public void TAdd(ContactUs t)
        {
            _contactUsDal.Add(t);
        }

        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TGetById(int id)
        {
            return _contactUsDal.GetById(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public void TUpdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
