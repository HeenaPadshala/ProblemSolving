using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemSolving.Models
{
    public class EqualityCheck
    {
        public dynamic input1 { get; set; }
        public dynamic input2 { get; set; }
        public string resultMessage { get; set; }
        public bool result { get; set; }

        public EqualityCheck CheckEqualityTest(EqualityCheck obj)
        {
            if ((input1.GetType() == input2.GetType()) && (input1.ToString() == input2.ToString()))
            {
                obj.resultMessage = "The type and value are equal.";
                obj.result = true;
                return obj;
            }
            else if ((input1.GetType() != input2.GetType()) && (input1.ToString() != input2.ToString()))
            {
                obj.resultMessage = "The type and value are different.";
            }
            else if (input1.GetType() != input2.GetType())
            {
                obj.resultMessage = "The type is different.";
            }
            else if (input1.ToString() != input2.ToString())
            {
                obj.resultMessage = "The value are different.";
            }
            obj.result = false;
            return obj;
        }
    }
}