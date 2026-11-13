
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VeracodeDemo
{
  internal class HTMLHelper : Controller
  {
        public void GenerateHTML(HttpResponse response, string responseMessage)
        {
            Response.ContentType = "text/html";
            Response.WriteAsync(
                "<html><body>Hello " + responseMessage + "</body></html>"
            );
        }
    }
}
