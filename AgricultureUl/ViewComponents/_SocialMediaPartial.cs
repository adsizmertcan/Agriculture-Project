using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _SocialMediaPartial:ViewComponent
	{
		private readonly ISocialMediaService _socialMediaService;

		public _SocialMediaPartial(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _socialMediaService.TGetList();
			return View(values);
		}
	}
}
