﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _addressService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAddress(Address P)
        {
            AddressValidator addressValidator = new AddressValidator();
            ValidationResult result = addressValidator.Validate(P);
            if (result.IsValid)
            {
                _addressService.TUpdate(P);
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
