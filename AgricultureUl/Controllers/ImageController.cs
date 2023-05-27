using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImagesService _imagesService;

        public ImageController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

        public IActionResult Index()
        {
            var values = _imagesService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image P)
        {
            ImageValidator imageValidator = new ImageValidator();
            ValidationResult result = imageValidator.Validate(P);
            if (result.IsValid)
            {
                _imagesService.TInsert(P);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteImage(int id)
        {
            var values = _imagesService.TGetById(id);
            _imagesService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var values = _imagesService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditImage(Image P)
        {
            ImageValidator imageValidator = new ImageValidator();
            ValidationResult result = imageValidator.Validate(P);
            if (result.IsValid)
            {
                _imagesService.TUpdate(P);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
