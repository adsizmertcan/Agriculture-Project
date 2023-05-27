using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
    public class _DashBoardScriptPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
