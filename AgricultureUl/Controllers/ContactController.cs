using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactsService _contactService;

        public ContactController(IContactsService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var values = _contactService.TGetById(id);
            return View(values);
        }
    }
}
