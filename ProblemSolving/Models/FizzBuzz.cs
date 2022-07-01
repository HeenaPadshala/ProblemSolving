using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemSolving.Models
{
    public class FizzBuzz
    {
        public int number { get; set; }
        public string Result { get; set; }
        public string getFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}