using ProblemSolving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemSolving.Controllers
{
    /// <summary>
    /// Convert Number to Corresponding Month Name
            ///  Create a function that takes */a number(from 1 to 12) and returns its corresponding month name as a string. 

            ///  Number  Month Name
            ///  1        January
            ///  2        February
            ///  3        March
            ///  4        April
            ///  5        May
            ///  6        June
            ///  7        July
            ///  8        August
            ///  9        September
            ///  10       October
            ///  11       November
            ///  12       December

            ///  Examples
            ///  MonthName(3) ➞ "March"
            ///  MonthName(12) ➞ "December"
            ///  MonthName(6) ➞ "June"
    /// </summary>
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