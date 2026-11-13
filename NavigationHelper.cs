using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace VeracodeDemo
{
  public class NavigationHelper : Controller // Inherit from Controller to access Redirect
  {
    [Microsoft.AspNetCore.Mvc.HttpGet("redirect")]
    public IActionResult RedirectToUrl(string navigateUrl)
    {
      return (IActionResult)Redirect(navigateUrl);
    }
  }
}
