using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementsService
    {
        private readonly IAnnouncementsDal _announcementsDal;

        public AnnouncementManager(IAnnouncementsDal announcementsDal)
        {
            _announcementsDal = announcementsDal;
        }

        public void AnnouncementStatusFalse(int id)
        {
            _announcementsDal.AnnouncementStatusFalse(id);
        }

        public void AnnouncementStatusTrue(int id)
        {
            _announcementsDal.AnnouncementStatusTrue(id);
        }

        public void TDelete(Announcement t)
        {
            _announcementsDal.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcementsDal.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementsDal.GetList();
        }

        public void TInsert(Announcement t)
        {
            _announcementsDal.Insert(t);
        }

        public void TUpdate(Announcement t)
        {
            _announcementsDal.Update(t);
        }
    }
}
