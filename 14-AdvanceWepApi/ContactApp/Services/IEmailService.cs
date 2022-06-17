using System.Threading.Tasks;
using ContactApp.Models;
using SendGrid;

namespace ContactApp.Services
{
    public interface IEmailService
    {
         Task<Response> SendSingleEmail(ComposeEmailVM payload);
         Task<Response> SendMultipleEmails();
    }
}