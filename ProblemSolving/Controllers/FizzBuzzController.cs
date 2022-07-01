using ProblemSolving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemSolving.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            FizzBuzz obj = new FizzBuzz();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(FizzBuzz obj)
        {
            if (obj.number > 0)
            {
                obj.Result = obj.getFizzBuzz(obj.number);
            }
            return View(obj);
        }
    }
}