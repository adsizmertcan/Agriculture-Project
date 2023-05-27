using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
		{
			var values = _adminService.TGetList();
			return View(values);
		}
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin P)
        {
            _adminService.TInsert(P);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            var values = _adminService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAdmin(Admin P)
        {
            _adminService.TUpdate(P);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            var values = _adminService.TGetById(id);
            _adminService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
