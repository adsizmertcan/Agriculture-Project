using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _ServicePartial : ViewComponent
	{
		private readonly IServicesService _servicesService;

		public _ServicePartial(IServicesService servicesService)
		{
			_servicesService = servicesService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _servicesService.TGetList();
			return View(values);
		}
	}
}
