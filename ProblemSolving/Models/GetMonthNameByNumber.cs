using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemSolving.Models
{
    public class GetMonthNameByNumber
    {
        public int month { get; set; }
        public string fullMonthName { get; set; }
        public string AbbreviatedMonthName { get; set; }

        public GetMonthNameByNumber getMonthName(GetMonthNameByNumber obj)
        {
            obj.fullMonthName = AbbreviatedMonthName = string.Empty;
            DateTime date = new DateTime(2020, obj.month, 1);
            obj.fullMonthName = date.ToString("MMMM");
            obj.AbbreviatedMonthName = date.ToString("MMM");
            return obj;
        }
    }
}