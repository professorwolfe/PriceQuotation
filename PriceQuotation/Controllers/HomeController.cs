using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DA = 0;
            ViewBag.TT = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DA = model.CalculateDiscountAmount();
                ViewBag.TT = model.CalculateTotal();
            }
            else
            {
                ViewBag.DA = 0;
                ViewBag.TT = 0;
            }
            return View(model);
        }
    }
}