using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Api.Models
{
    public class Response
    {
        public Position position { get; set; }
        public string Message { get; set; }

        public class Position
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }

}