using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
    public class _DashBoardChartPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 93;
            ViewBag.v3 = 49;
            ViewBag.v4 = 23;
            ViewBag.v5 = 15;
            return View();
        }
    }
}
