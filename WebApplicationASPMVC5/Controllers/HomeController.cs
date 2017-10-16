using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplicationASPMVC5.Models;

namespace WebApplicationASPMVC5.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext(); // создаем контекст данных

        public ActionResult Index()
        {            
            IEnumerable<Book> books = db.Books; // получаем из бд все объекты Book
            ViewBag.Books = books; // передаем все объекты в динамическое свойство Books в ViewBag            
            return View(); // возвращаем представление
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    }
}