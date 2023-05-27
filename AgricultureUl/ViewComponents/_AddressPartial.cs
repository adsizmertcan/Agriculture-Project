﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.ViewComponents
{
	public class _AddressPartial:ViewComponent
	{
		private readonly IAddressService _addressService;

		public _AddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _addressService.TGetList();
			return View(values);
		}
	}
}
