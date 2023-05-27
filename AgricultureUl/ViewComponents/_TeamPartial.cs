using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _TeamPartial:ViewComponent
	{
		private readonly ITeamsService _teamService;

		public _TeamPartial(ITeamsService teamService)
		{
			_teamService = teamService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _teamService.TGetList();
			return View(values);
		}
	}
}
