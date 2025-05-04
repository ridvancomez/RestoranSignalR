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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void TAdd(Discount t)
        {
            _discountDal.Add(t);
        }

        public void TDelete(Discount t)
        {
            _discountDal.Delete(t);
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public List<Discount> TGetList()
        {
            return _discountDal.GetList();
        }

        public void TUpdate(Discount t)
        {
            _discountDal.Update(t);
        }
    }
}
