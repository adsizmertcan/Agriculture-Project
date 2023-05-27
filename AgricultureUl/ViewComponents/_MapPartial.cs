using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _MapPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			AgricultureContext context = new AgricultureContext();
			var values = context.Addresses.Select(X => X.MapInfo).FirstOrDefault();
			ViewBag.V = values;
			return View();
		}
	}
}
