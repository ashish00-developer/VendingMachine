using System.Web.Mvc;
using VendingMachine.Models;

namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVendingMachineHelper _vendingMachineHelper;

        public HomeController()
        {
        }
        public HomeController(IVendingMachineHelper vendingMachineHelper)
        {
            _vendingMachineHelper = vendingMachineHelper;
        }
        public ActionResult Index()
        {
            IVendingMachineHelper vendingMachine = new VendingMachineHelper();
            return View(vendingMachine);
        }

        public ActionResult SelectProduct(Product.ProductList Name)
        {
            return Json(new { price = _vendingMachineHelper.GetProductPrice(Name)}, JsonRequestBehavior.AllowGet);
        }
    }
}