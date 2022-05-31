using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Controllers {
    public class CategoriesController : Controller {
        static List<CategoriesModel> categories = new List<CategoriesModel> {
            new CategoriesModel {id = 1, name = "Food"},
            new CategoriesModel {id = 2, name = "Tech"},
            new CategoriesModel {id = 3, name = "Sports"}
        };

        // GET: CategoriesController
        public ActionResult Index() {
            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id) {
            var selected = categories.First<CategoriesModel>(x => x.id == id);
            ViewBag.Message = "The selected category is: " + selected.name;
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
