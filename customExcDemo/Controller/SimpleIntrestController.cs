using customExcDemo.Controller.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exception = customExcDemo.Controller.Filter.Exception;

namespace customExcDemo.Controller
{
    public class SimpleIntrestController : ApiController
    {
        [Exception]
        [HttpGet]
        public int SI(int p,int r,int n)
        {
            return p * r * n / 100;
        }
    }
}
