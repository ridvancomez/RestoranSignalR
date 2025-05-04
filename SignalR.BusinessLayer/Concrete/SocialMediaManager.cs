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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Add(t);
        }
        public void TDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }
        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }
        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }
        public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
