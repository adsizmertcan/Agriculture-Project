using AgricultureUl.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUl.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<ProductClass> products = new List<ProductClass>();
            products.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 85,
            });
            products.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 200
            });
            products.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 150
            });
            products.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 30
            });
            return Json(new { jsonlist = products });
        }
    }
}
