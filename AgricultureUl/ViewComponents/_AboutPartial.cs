using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _AboutPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			AgricultureContext context = new AgricultureContext();
			var values = context.Abouts.ToList();
			return View(values);
		}
	}
}
