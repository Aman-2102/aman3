using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using new_cab.Models;
using new_cab.Controllers;
namespace new_cab.Controllers
{
    public class cabController : Controller
    {
        // GET: cab
        public ActionResult Index()
        {
        cab_data__access cda = new cab_data__access();

            IEnumerable<UserDetail> ul = cda.Getallrecord();
            return View(ul);
        }

        // GET: cab/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: cab/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cab/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: cab/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: cab/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: cab/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: cab/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
