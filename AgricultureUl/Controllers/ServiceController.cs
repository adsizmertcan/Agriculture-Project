using AgricultureUl.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace AgricultureUl.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        public IActionResult Index()
        {
            var values = _servicesService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if(ModelState.IsValid)
            {
                _servicesService.TInsert(new Service()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Image = model.Image

                });
                return RedirectToAction("Index");
            }
            return View(model);
            //_servicesService.TInsert(service);

            //return RedirectToAction("Index");


        }
        public IActionResult DeleteService(int id)
        {
            var values = _servicesService.TGetById(id);
            _servicesService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _servicesService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _servicesService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
