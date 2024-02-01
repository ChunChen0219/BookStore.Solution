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
    public class BooksController : Controller
    {
        private static IBooksRepository _repos = new BooksEFRepository();
        private BooksService _service = new BooksService(_repos);
        // GET: Books
        public ActionResult Index()
        {
            var vms = _service.Search();
            return View(vms);
        }

        //---------------------新增----------
        public ActionResult Create()
        {

            return View();
        }
    }
}