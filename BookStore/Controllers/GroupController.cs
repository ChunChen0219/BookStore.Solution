using BookStore.Models.EFModels;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class GroupController : Controller
    {
        private AppDbContext db = new AppDbContext(); 


        public ActionResult Index()
        {
            var groups = db.GroupPermissions.ToList();
            return View(groups);
        }


        public ActionResult Create()
        {
            var viewModel = new GroupCreateVm
            {
                AllFunctions = db.GroupFunctions.ToList(),
                SelectedFunctions = new List<int>()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(GroupCreateVm viewModel)
        {
            if (ModelState.IsValid)
            {
                var group = new GroupPermission { GroupName = viewModel.GroupName };

                return RedirectToAction("Index");
            }
            viewModel.AllFunctions = db.GroupFunctions.ToList();
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var group = db.GroupPermissions.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            var canChooseFunctions = group.GroupFunctions.ToList();

            var viewModel = new GroupEditVm
            {
                GroupId = group.Id,
                CanChooseFunctions = canChooseFunctions,
                AllFunctions = db.GroupFunctions.ToList() 
            };

            return View(viewModel);
        }



    }
}