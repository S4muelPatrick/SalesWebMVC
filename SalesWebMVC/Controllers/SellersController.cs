using Microsoft.AspNetCore.Mvc;
//using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        /*private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();
            return View(list);
        }*/
        public IActionResult Index()
        {
            return View();        }
    }
}
