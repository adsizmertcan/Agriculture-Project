using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly IAnnouncementsService _announcementsService;

        public AnnouncementsController(IAnnouncementsService announcementsService)
        {
            _announcementsService = announcementsService;
        }

        public IActionResult Index()
        {
            var values = _announcementsService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement P)
        {
            P.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            P.Status = false;
            _announcementsService.TInsert(P);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementsService.TGetById(id);
            _announcementsService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var values = _announcementsService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement P)
        {
            _announcementsService.TUpdate(P);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementsService.AnnouncementStatusTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementsService.AnnouncementStatusFalse(id);
            return RedirectToAction("Index");
        }

    }
}
