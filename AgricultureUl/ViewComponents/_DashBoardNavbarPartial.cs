using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
    public class _DashBoardNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
