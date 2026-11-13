using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace VeracodeDemo
{
  public class APIHelper
  {
    private const string ciscoAPIKey =
        "sk_test_1234567890";

    private const string ciscoAPIPass =
        "sk_test_pass123456!";
    private readonly HttpClient _client = new HttpClient();

    public void CallApi()
    {
      Console.WriteLine(ciscoAPIKey);
    }
    public async Task<string> GetResponse(string url)
    {
      return await _client.GetStringAsync(url);
    }


    [Microsoft.AspNetCore.Mvc.HttpDelete]
    [Microsoft.AspNetCore.Mvc.Route("admin/deleteOrder")]
    public IActionResult DeleteOrderr(int orderId)
    {
      // No authorization check is performed.
      // Any authenticated/unauthenticated caller may reach this endpoint.

      DeleteOrderById(orderId);

      return new OkObjectResult("Order deleted");
    }

    private int DeleteOrderById(int userId)
    {
      // Simulated database operation
      int orderDeleted = 1;
      return orderDeleted;
      // Simulate a successful deletion
    }


  }
}
