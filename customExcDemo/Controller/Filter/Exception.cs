using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace customExcDemo.Controller.Filter
{
    public class Exception:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnException(actionExecutedContext);

            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            response.Content = new StringContent("Principle amount is Negative");
            actionExecutedContext.Response = response;
        }
    }
}