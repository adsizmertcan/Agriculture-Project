using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
    public class _DashBoardTablePartial: ViewComponent
    {
        private readonly IContactsService _contactService;

        public _DashBoardTablePartial(IContactsService contactService)
        {
            _contactService = contactService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
