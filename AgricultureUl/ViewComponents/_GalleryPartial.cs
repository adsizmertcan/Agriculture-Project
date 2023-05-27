using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _GalleryPartial:ViewComponent
	{
		private readonly IImagesService _ImageService;

		public _GalleryPartial(IImagesService imageService)
		{
			_ImageService = imageService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _ImageService.TGetList();
			return View(values);
		}
	}
}
