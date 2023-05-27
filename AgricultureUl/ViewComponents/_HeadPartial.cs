using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
