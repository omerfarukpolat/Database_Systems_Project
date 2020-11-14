﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using Bil372_Odev1_Grup6.Models;

namespace Bil372_Odev1_Grup6.Controllers
{
    public class Product_FeaturesController : Controller
    {
        // GET: Product_Features/Create

        DatabaseController db = new DatabaseController("1");
        public ActionResult Create()
        {
            return View();
        }

        // POST: Features/Create
        [HttpPost]
        public ActionResult Create(string scode, string fid, string minval, string maxval)
        {
            db.insertProductFeatures(Int32.Parse(scode), Int32.Parse(fid), float.Parse(minval, CultureInfo.InvariantCulture), float.Parse(maxval, CultureInfo.InvariantCulture));


            return View();

        }


        // GET: Brand_Orgs/Search1
        public ActionResult Search1()
        {
            return View();
        }

        // POST: Brand_Orgs/Search1
        [HttpPost]
        public ActionResult Search1(string pname)
        {

            List<LINKINGPRODUCTFEATURES> model = db.searchWithProductName(pname);

            return View(model);

        }

        // GET: Brand_Orgs/Search2
        public ActionResult Search2()
        {



            return View();
        }

        // POST: Brand_Orgs/Search2
        [HttpPost]
        public ActionResult Search2(string fname)
        {

            List<LINKINGPRODUCTFEATURES> model = db.searchWithFeature(fname);

            return View(model);

        }
    }
}