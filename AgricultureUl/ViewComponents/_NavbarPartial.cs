using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
