using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
    public class _DashBoardHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
