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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int TActiveCategoryCount()
        {
            return _categoryDal.ActiveCategoryCount();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Add(t);
        }

        public int TCategoryCount()
        {
            return _categoryDal.CategoryCount();
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public int TPassiveCategoryCount()
        {
            return _categoryDal.PassiveCategoryCount();
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
