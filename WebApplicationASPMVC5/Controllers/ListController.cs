using System.Collections.Generic;
using System.Web.Mvc;
using WebApplicationASPMVC5.Models;

namespace WebApplicationASPMVC5.Controllers
{
    public class ListController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Purchase> purchases = db.Purchases;
            ViewBag.Purchases = purchases;
            return View();
        }
    }
}