using Knockout.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOut_PQ_master_detail.Controllers
{
    public class personalController : Controller
    {
        // GET: personal
        public ActionResult Index()
        {
            return View();
        }

        // GET: personal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: personal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: personal/Create
        [HttpPost]
        public ActionResult Create(User data)
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

        // GET: personal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: personal/Edit/5
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

        // GET: personal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: personal/Delete/5
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
