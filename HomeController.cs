using Microsoft.AspNetCore.Mvc;

namespace VeracodeDemo
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly APIHelper _apiHelper = new();
        private readonly EncryptionHelper _encryptionHelper = new();
        private readonly HTMLHelper _htmlHelper = new();
        private readonly LogHelper _logHelper = new();
        private readonly NavigationHelper _navigationHelper = new();
        private readonly OrderHelper _orderHelper = new();
        private readonly ProcessAutoTask _processAutoTask = new();
        private readonly QuoteDataAccess _quoteDataAccess = new();

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok(new { message = "Veracode Demo Application is running" });
        }

        [HttpGet("generate-token")]
        public IActionResult GenerateToken(string clientId)
        {
            var token = _encryptionHelper.GenerateToken(clientId);
            return Ok(new { token });
        }

        [HttpGet("api-response")]
        public async Task<IActionResult> GetApiResponse(string url)
        {
            try
            {
                var response = await _apiHelper.GetResponse(url);
                return Ok(new { response });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("hardcoded-secret")]
        public IActionResult HardCodedSecret()
        {
            _apiHelper.CallApi();
            return Ok("API called");
        }

        [HttpGet("sql-query")]
        public IActionResult GetUserData(string username)
        {
            _quoteDataAccess.GetUser(username);
            return Ok("User retrieved");
        }

        [HttpPost("xss-render")]
        public IActionResult RenderHtml(string content)
        {
            _htmlHelper.GenerateHTML(Response, content);
            return Ok("HTML rendered");
        }

        [HttpPost("command-injection")]
        public IActionResult PingHost(string host)
        {
            _processAutoTask.CheckPing(host);
            return Ok("Ping executed");
        }

        [HttpGet("read-file")]
        public IActionResult ReadLogFile(string fileName)
        {
            var result = _logHelper.WriteToFile(fileName);
            return Ok(new { content = result });
        }

        [HttpGet("redirect")]
        public IActionResult RedirectPage(string navigateUrl)
        {
            return Redirect(navigateUrl);
        }

        [HttpDelete("delete-order")]
        public IActionResult DeleteOrder(int orderId)
        {
            _orderHelper.DeleteOrder(orderId);
            return Ok("Order deleted");
        }

        [HttpGet("get-quote")]
        public IActionResult GetQuote(string quoteNo)
        {
            var quote = _quoteDataAccess.GetQuote(quoteNo);
            return Ok(new { quote });
        }
    }
}
