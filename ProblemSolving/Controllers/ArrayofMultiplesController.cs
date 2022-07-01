using ProblemSolving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemSolving.Controllers
{
    public class ArrayofMultiplesController : Controller
    {
        // GET: ArrayofMultiples
        public ActionResult Index()
        {
            ArrayofMultiples obj = new ArrayofMultiples();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(ArrayofMultiples objValue)
        {
            if (objValue.number > 0 && objValue.length > 0)
            {
                objValue = objValue.getArrayofMultiples(objValue);
            }
            return View(objValue);
        }
    }
}