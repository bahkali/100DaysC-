using System.Threading.Tasks;
using ContactApp.Models;
using SendGrid;

namespace ContactApp.Data.Services
{
    public interface IEmailService
    {
         Task<Response> SendSingleEmail(ComposeEmailVM payload);
         Task<Response> SendMultipleEmails();
    }
}