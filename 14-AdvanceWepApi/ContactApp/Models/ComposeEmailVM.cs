using Microsoft.AspNetCore.Http;

namespace ContactApp.Models
{
    public class ComposeEmailVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public IFormFile Attachment {get; set;}
    }
}