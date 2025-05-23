﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;
        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }
        public void TAdd(MenuTable t)
        {
            _menuTableDal.Add(t);
        }

        public void TDelete(MenuTable t)
        {
            _menuTableDal.Delete(t);
        }

        public MenuTable TGetById(int id)
        {
            return _menuTableDal.GetById(id);
        }

        public List<MenuTable> TGetList()
        {
            return _menuTableDal.GetList();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable t)
        {
            _menuTableDal.Update(t);
        }
    }
}
