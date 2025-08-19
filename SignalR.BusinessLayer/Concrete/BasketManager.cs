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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public List<Basket> GetListByMenuTableId(int menuTableId)
        {
            return _basketDal.GetListByMenuTableId(menuTableId);
        }

        public void TAdd(Basket t)
        {
            _basketDal.Add(t);
        }

        public void TDelete(Basket t)
        {
            _basketDal.Delete(t);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public List<Basket> TGetList()
        {
            return _basketDal.GetList();
        }

        public void TUpdate(Basket t)
        {
            _basketDal.Update(t);
        }
    }
}
