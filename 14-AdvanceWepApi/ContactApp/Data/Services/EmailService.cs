using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Models;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ContactApp.Data.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Response> SendSingleEmail(ComposeEmailVM payload)
        {
            var apiKey = _configuration.GetSection("SendGrid")["ApiKey"];
            // create the client
            var client = new SendGridClient(apiKey);
            // define the email to send from
            var from = new EmailAddress("kalimamadou@gmail.com", "Kaly Bah");

            var subject = payload.Subject;
            // define the email to send to
            var to = new EmailAddress(payload.Email, $"{payload.FirstName} {payload.LastName}");
            var textContent = payload.Body;
            var htmlContent = $"<strong>{payload.Body}</strong>";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, textContent, htmlContent);
            // Attachment
            if(payload.Attachment != null && payload.Attachment.Length > 0)
            {
                var fileContent = "";
                byte[] byteData;
                using (var reader = new StreamReader(payload.Attachment.OpenReadStream()))
                {
                    fileContent = reader.ReadToEnd().ToString();
                    byteData = Encoding.ASCII.GetBytes(fileContent);
                }
                Attachment attachment = new Attachment(){
                    Content = Convert.ToBase64String(byteData),
                    Filename = payload.Attachment.FileName,
                    Type = payload.Attachment.ContentType,
                    Disposition = "attachment"
                };
                msg.AddAttachment(attachment);
            }
            
            var request = await client.SendEmailAsync(msg);
            return request;
        }
    
        public Task<Response> SendMultipleEmails()
        {
            var apiKey = _configuration.GetSection("SendGrid")["ApiKey"];
            // create the client
            var client = new SendGridClient(apiKey);
            // define the email to send from
            var from = new EmailAddress("kalimamadou@gmail.com", "Kaly Bah");

            var subject = "Multiple emails";
            // define the emails to send to
            var tos = new List<EmailAddress>(){ 
                 new EmailAddress("me2@me.com", $"First last - 1"),
                 new EmailAddress("me2@me.com", $"First last - 2"),
            };
            // Content
            var textContent = "Multiple emails content";
            var htmlContent = $"<strong>Multiple emails content</strong>";

            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, textContent, htmlContent);

            var request = client.SendEmailAsync(msg);
            request.Wait();

            var result = request.Result;
            return null;
        }
    }
}