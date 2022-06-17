using ContactApp.Services;
using ContactApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.Controllers
{
    [ApiController]
    [Route("api/message")]
    public class messageController : ControllerBase
    {
        private readonly IEmailService _service;
        public messageController(IEmailService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult TestEndpoint()
        {
            return Ok("Message Endpoint work");
        }
        
        [HttpPost]
        public IActionResult SendEmail([FromForm] ComposeEmailVM composeEmail)
        {
            try
            {
                var response =  _service.SendSingleEmail(composeEmail);
                 return Ok(response.Result);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    
    }
}