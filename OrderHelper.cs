using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
//using System.Web.Http;

namespace VeracodeDemo
{
  public class OrderHelper
  {
    [HttpDelete("admin/delete-order")]
    public IActionResult DeleteOrder(int orderId)
    {
      // No authorization check is performed.
      // Any authenticated/unauthenticated caller may reach this endpoint.

      DeleteOrderById(orderId);

      return new Microsoft.AspNetCore.Mvc.OkObjectResult("User deleted");
    }
    private void DeleteOrderById(int userId)
    {
      // Simulated database operation
    }
  }
}
