using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IContactsService _contactService;

		public DefaultController(IContactsService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SendMessage(Contact P)
		{
			P.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			_contactService.TInsert(P);
			return RedirectToAction("Index", "Default");
		}

		//Script Controller burada

		public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}

	}
}
