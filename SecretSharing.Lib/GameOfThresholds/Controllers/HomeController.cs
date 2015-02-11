﻿using SecretSharing.ProfilerRunner;
using SecretSharingCore.Algorithms.GeneralizedAccessStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace GameOfThresholds.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Details/5

        public ActionResult DetectThreshold(string access)
        {
            AccessStructure acc = new AccessStructure(access);
            var expanded = new  List<QualifiedSubset>();
            var qualified = new  List<QualifiedSubset>();
            var thresholds = new List<ThresholdSubset>();
            var remaining = new List<QualifiedSubset>();

            Program.ServeThresholdDetection(acc, out expanded,out  qualified,out  thresholds,out remaining);

            ViewBag.expanded = expanded;
            ViewBag.qualified = qualified;
            ViewBag.thresholds = thresholds;
            ViewBag.remaining = remaining;

            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

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

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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