using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFremework
{
    public class EntityFrameworkAnnounCementDal : GenericRepository<Announcement>, IAnnouncementsDal
    {
        public void AnnouncementStatusFalse(int id)
        {
            using var context = new AgricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnouncementStatusTrue(int id)
        {
            using var context = new AgricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
