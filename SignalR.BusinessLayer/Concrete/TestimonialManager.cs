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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void TAdd(Testimonial t)
        {
            _testimonialDal.Add(t);
        }
        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }
        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }
        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }
        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
