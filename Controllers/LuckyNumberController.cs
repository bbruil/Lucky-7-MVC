using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lucky_7_MVC.Controllers
{
    public class LuckyNumberController : Controller
    {
        // GET: LuckyNumber
        public ActionResult Index(int luck=7)
        {
            int Lucky = luck;
            
            string display = "";
            Random randint = new System.Random();
            ViewBag.Display = display;
            int rand1 = randint.Next(1, 9);
            int rand2 = randint.Next(1, 9);
            int rand3 = randint.Next(1, 9);
            ViewBag.Rand1 = rand1;
            ViewBag.Rand2 = rand2;
            ViewBag.Rand3 = rand3;
            if (rand1 == Lucky || rand2 == Lucky || rand3 == Lucky)
            {
                  display = "block";
            }
            else {   display = "none"; }
            ViewBag.Display = display;
            ViewBag.Title = "LuckyNumberView";
            ViewBag.Heading = luck;
            return View();
        }

        // GET: LuckyNumber/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LuckyNumber/Create
        public ActionResult Create()
        {
            return View();
      
        }

        // POST: LuckyNumber/Create
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

        // GET: LuckyNumber/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LuckyNumber/Edit/5
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

        // GET: LuckyNumber/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LuckyNumber/Delete/5
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
