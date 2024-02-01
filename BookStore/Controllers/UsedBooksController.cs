using BookStore.Models.Interfaces;
using BookStore.Models.Repositories;
using BookStore.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class UsedBooksController : Controller
    {
        private static IUsedBookRepository _repos = new UsedBookRepository();
        private UsedBookService _service = new UsedBookService(_repos);
        // GET: UsedBooks
        public ActionResult Index(string email,string ISBN)
        {
            var vms = _service.Search(email,ISBN);
            return View(vms);
        }
    }
}