using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebFormJavascript.Models
{
    public class Result
    {

        public bool Correct { get; set; }

        public string Message { get; set; }

        public List<object> Objects { get; set; }

        public object Object { get; set; }

    }
}