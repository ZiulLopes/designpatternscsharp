using System;
using System.Collections.Generic;

namespace chainofresponsibility.Models
{
    public class ResponseModel
    {
        public int Code { get; set; }
        public List<string> Messages { get; set; }
        public string Data { get; set; }
    }
}