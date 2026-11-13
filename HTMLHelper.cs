using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  internal class HTMLHelper
  {
    public void GenerateHTML(HttpResponse response, string responseMessage)
    {
      response.ContentType = "text/html";

      response.WriteAsync(
          "<html><body>Hello " + responseMessage + "</body></html>"
      );
    }
  }
}
