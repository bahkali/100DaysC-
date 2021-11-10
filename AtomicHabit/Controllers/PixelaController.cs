using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AtomicHabit.Controllers
{
    public class PixelaController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public PixelaController( IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public IActionResult Index()
        {
            // Get the Data
            var request = new HttpRequestMessage(HttpMethod.Get, "");
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {

            }else
            {

            }
            return View();
        }

        static async Task createUser()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "");
            request.Headers.Add("token", "@userId");
            request.Headers.Add("username", "@userId");
            request.Headers.Add("X-USER-TOKEN", "@userId");

            request.Content = new StringContent(JsonSerializer.Serialize());

        }
             
    }
}
