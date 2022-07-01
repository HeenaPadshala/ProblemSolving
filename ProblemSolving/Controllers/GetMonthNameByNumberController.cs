﻿using ProblemSolving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemSolving.Controllers
{
    public class GetMonthNameByNumberController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            GetMonthNameByNumber obj = new GetMonthNameByNumber();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(GetMonthNameByNumber objValue)
        {
            if (objValue.month > 0)
            {
                objValue = objValue.getMonthName(objValue);
            }
            return View(objValue);
        }
    }
}