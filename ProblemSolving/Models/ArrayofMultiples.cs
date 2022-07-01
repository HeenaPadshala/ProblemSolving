using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemSolving.Models
{
    public class ArrayofMultiples
    {
        public int number { get; set; }
        public int length { get; set; }
        public int[] arrayResult { get; set; } = new int[0];

        public ArrayofMultiples getArrayofMultiples(ArrayofMultiples obj)
        {
            obj.arrayResult = new int[length];
            for (int i = 1; i <= length; i++)
            {
                obj.arrayResult[i-1] = (i * obj.number);
            }
            return obj;
        }
    }
}